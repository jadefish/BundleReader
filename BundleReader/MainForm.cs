using BundleReader.Properties;
using ModernStuff;
using ModernStuff.Controls;
using ModernStuff.Renderers;
using PlistCS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BundleReader
{
	public partial class MainForm : ModernForm
	{
		private static SoundPlayer sp = new SoundPlayer(BundleReader.Properties.Resources.save_icon);
		private DirectoryInfo currentAppFile;
		private Bundle bundle;
		public bool plistInspectorOpen = false;
		PlistInspector plistInspector = null;
		private Dictionary<string, object> serverPlist = null;

		public MainForm()
		{
			InitializeComponent();
			this.Font = SystemFonts.MessageBoxFont;
			menuStrip.Renderer = new ModernMenuStripRenderer();
			label_overlay.Font = new Font(this.Font.FontFamily, 13.0F, FontStyle.Regular);

			foreach (Control control in this.panel_middle.Controls)
			{
				if (control.GetType().Equals(typeof(Label)))
				{
					if (control.Tag != null && control.Tag.GetType().Equals(typeof(string)))
					{
						if ((control.Tag as string).Equals("header", StringComparison.CurrentCultureIgnoreCase))
						{
							(control as Label).Font = new Font(control.Font, FontStyle.Bold);
						}
					}
				}
			}

			foreach (Control control in this.panel_right.Controls)
			{
				if (control.GetType().Equals(typeof(Label)))
				{
					if (control.Tag != null && control.Tag.GetType().Equals(typeof(string)))
					{
						if ((control.Tag as string).Equals("header", StringComparison.CurrentCultureIgnoreCase))
						{
							(control as Label).Font = new Font(control.Font, FontStyle.Bold);
						}
					}
				}
			}

			panel_overlay.BringToFront();

			UpdateTextBoxes();
		}

		private void toggleThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.InterfaceTheme == InterfaceTheme.Dark)
				this.InterfaceTheme = InterfaceTheme.Light;
			else
				this.InterfaceTheme = InterfaceTheme.Dark;

			UpdateTextBoxes();
		}

		private void UpdateTextBoxes()
		{
			foreach (Control control in this.panel_middle.Controls)
			{
				if (control.GetType().Equals(typeof(TextBoxPlus)))
				{
					(control as TextBoxPlus).BackColor = this.Colors.WindowBackground;
					(control as TextBoxPlus).ForeColor = this.Colors.TextColor;
				}
			}

			foreach (Control control in this.panel_right.Controls)
			{
				if (control.GetType().Equals(typeof(TextBoxPlus)))
				{
					(control as TextBoxPlus).BackColor = this.Colors.WindowBackground;
					(control as TextBoxPlus).ForeColor = this.Colors.TextColor;
				}
			}
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			panel_overlay.BringToFront();
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
		}

		private void MainForm_DragLeave(object sender, EventArgs e)
		{
			if (currentAppFile != null) panel_overlay.SendToBack();
		}

		private async void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

			if (files.Length > 0)
			{
				// Accept only the first file:
				currentAppFile = new DirectoryInfo(files[0]);

				if (currentAppFile.Exists)
				{
					try
					{
						await LoadBundle(currentAppFile.FullName);
					}
					catch (Exception ex)
					{
						Debug.WriteLine(ex.Message);
						ClearFields();
						bundle = null;
						panel_overlay.BringToFront();
					}
				}
			}
		}

		private async Task LoadBundle(string fileName)
		{
			if (this.bundle != null)
			{
				ClearFields();
				this.bundle = null;
			}

			this.bundle = new Bundle(fileName);

			if (this.bundle.IsValid)
			{
				textBox_fileName.Text = this.bundle.AppFile.Name;
				this.Text = this.bundle.FileName;

				panel_overlay.SendToBack();
				ToggleMenuItems(true);

				textBox_displayName.Text = this.bundle.DisplayName;
				textBox_bundleVersion.Text = this.bundle.BundleVersion;
				textBox_shortVersion.Text = this.bundle.ShortVersion;
				textBox_getInfoVersion.Text = this.bundle.GetInfoVersion;
				textBox_buildVersion.Text = this.bundle.BuildVersion;
				textBox_bundleID.Text = this.bundle.BundleId;
				textBox_sparkleUrl.Text = this.bundle.SparkleUrl;
				textBox_architectureOS.Text = "OS X " + this.bundle.MinOSVersion + ", " + this.bundle.Architecture.ToString();
				textBox_localIcons.Text = this.bundle.LocalIconSize;
				textBox_MUIDVersion.Text = this.bundle.MUProductId + "\t" + this.bundle.ServerVersion;
				textBox_MUMatch.Text = this.bundle.AutoMatchUrl;
				textBox_localLanguages.Text = String.Join(",", this.bundle.LocalLanguages);
				//textBox_serverLanguages.Text = String.Join(",", currentApp.ServerLanguages);
				textBox_mudVersion.Text = this.bundle.MUDVersion;

				if (this.bundle.PngIconFile != null)
				{
					using (FileStream stream = new FileStream(this.bundle.PngIconFile.FullName, FileMode.Open, FileAccess.Read))
					{
						pictureBoxLink_appIcon.BackgroundImage = Image.FromStream(stream);
					}

					pictureBoxLink_appIcon.Enabled = true;
					modernButton_upload.Enabled = true;
				}
				else
				{
					// Use generic app icon:
					pictureBoxLink_appIcon.BackgroundImage = Resources.generic_app;
				}

				if (!menuItem_sendServerRequests.Checked)
				{
					return;
				}

				var serverResult = await getServerPlist(this.bundle);
				List<object> data = (List<object>)serverResult["entries"];
				this.serverPlist = (Dictionary<string, object>)data[0];

				if (this.serverPlist != null)
				{
					object rawItem = null;
					this.serverPlist.TryGetValue("mu_id", out rawItem);

					if (rawItem != null && rawItem.ToString().Length > 0)
					{
						this.bundle.MUProductId = int.Parse(rawItem.ToString());
						rawItem = null;
					}
					else
					{
						return;
					}

					this.serverPlist.TryGetValue("current_version", out rawItem);

					if (rawItem != null)
					{
						this.bundle.ServerVersion = rawItem.ToString();
						Debug.WriteLine("server version: " + this.bundle.ServerVersion);
						rawItem = null;
					}
					
					// TODO: move all server data UI updates to separate Task
					textBox_MUIDVersion.Text = this.bundle.MUProductId + " " + this.bundle.ServerVersion;
					this.bundle.AutoMatchUrl = "http://www.macupdate.com/app/mac/" + this.bundle.MUProductId + "/"
						+ this.bundle.DisplayName.Replace(" ", "-").ToLower().Trim();
					textBox_MUMatch.Text = this.bundle.AutoMatchUrl;
				}
			}
			else
			{
				ClearFields();
				bundle = null;
				panel_overlay.BringToFront();
			}
		}

		private void ToggleMenuItems(bool enabled)
		{
			closeToolStripMenuItem.Enabled = enabled;
			exportFieldsToolStripMenuItem.Enabled = enabled;
			copyFieldsToolStripMenuItem.Enabled = enabled;
			plistInspectorToolStripMenuItem.Enabled = enabled;
		}

		private void pictureBoxLink_appIcon_Click(object sender, EventArgs e)
		{
			if (bundle.PngIconFile != null)
			{
				string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string destinationFileName = Path.Combine(desktopPath, String.Format("{0}.png", bundle.DisplayName));
				File.Copy(bundle.PngIconFile.FullName, destinationFileName, true);

				sp.Play();
			}
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel_overlay.BringToFront();
			currentAppFile = null;
			ToggleMenuItems(false);
			ClearFields();
		}

		private void ClearFields()
		{
			foreach (Control control in this.panel_middle.Controls)
			{
				if (control.GetType().Equals(typeof(TextBoxPlus)))
				{
					(control as TextBoxPlus).Text = "-";
				}
			}

			foreach (Control control in this.panel_right.Controls)
			{
				if (control.GetType().Equals(typeof(TextBoxPlus)))
				{
					if (control.GetType().Equals(typeof(TextBoxPlus)))
					{
						(control as TextBoxPlus).Text = "-";
					}
				}
			}

			this.Text = "BundleReader";
			modernButton_upload.Enabled = false;
			pictureBoxLink_appIcon.Enabled = false;
			pictureBoxLink_appIcon.BackgroundImage = null;
		}

		private void clearFieldsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void mUHomeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.macupdate.com");
		}

		private void mUContentHomeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.macupdate.com");
		}

		private void queueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.macupdate.com");
		}

		private void plistInspectorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open PList inspector form:

			this.plistInspector = new PlistInspector(this.bundle.Plist);
		}

		private static async Task<Dictionary<string, object>> getServerPlist(Bundle bundle)
		{
			// TODO: although NO_DATA for much of the request body seems to work fine,
			// figuring out the actual values would certainly be ideal.

			const int MEMBER_ID = 653844;
			const string AUTOMATCH_URL = "https://desktop.macupdate.com/mud6scan/automatchmudversion2";
			const string NO_DATA = "-";

			string serial = NO_DATA;					// ???
			string uuid = NO_DATA;						// NSString *uuidString = [[[NSUserDefaults standardUserDefaults] objectForKey:@"penguin"] urlEncodeValue];

			string name = NO_DATA;						// self.name = [[item valueForAttribute:(id)kMDItemFSName] trimmedString];
			string digest = NO_DATA;					// self.digestString = [self.localPath md5HexHash];
			string displayName = bundle.DisplayName;	// self.localizedName = [[item valueForAttribute:(id)kMDItemDisplayName] trimmedString];
			string lastOpened = NO_DATA;				// self.lastOpened = [item valueForAttribute:(id)kMDItemLastUsedDate];

			var data = new Dictionary<string, string>
			{
				{ "mud", "MUDVersion2.0" },
				{ "c", serial },
				{ "p", "1" },
				{ "mid", MEMBER_ID.ToString() },
				{ "uuid", uuid },
				{ "app[0][t]", name },
				{ "app[0][p]", digest },
				{ "app[0][d]", bundle.DisplayName },
				{ "app[0][v]", bundle.MUDVersion },
				{ "app[0][b]", bundle.BundleId },
				{ "app[0][m]", lastOpened },
			};
			
			var payload = new FormUrlEncodedContent(data);
			string responseString = string.Empty;

			using (HttpClient client = new HttpClient())
			{
				client.Timeout = TimeSpan.FromMilliseconds(1000);
				var response = await client.PostAsync(AUTOMATCH_URL, payload);
				responseString = await response.Content.ReadAsStringAsync();
			}

			if (!string.IsNullOrEmpty(responseString))
			{
				return (Dictionary<string, object>)Plist.readPlistSource(responseString);
			}

			return new Dictionary<string, object>();
		}
	}
}
