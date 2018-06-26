using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using ModernStuff.Controls;
using ModernStuff.Renderers;

namespace BundleReader
{
	public partial class PlistInspector : ModernForm
	{
		private ModernForm parentForm = null;

		[Browsable(false)]
		public new ModernForm ParentForm
		{
			get { return this.parentForm; }
			set { this.parentForm = value; }
		}

		public PlistInspector(Dictionary<string, object> plist)
		{
			InitializeComponent();
			contextMenu.Renderer = new ModernMenuStripRenderer();

			this.FormClosed += (s, e) =>
			{
				if (this.ParentForm != null)
				{
					(this.ParentForm as MainForm).plistInspectorOpen = false;
				}
			};

			foreach (var item in plist)
			{
				listBox1.Items.Add(item.Key + ": " + item.Value.ToString());
			}
		}

		private void copyToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
				Clipboard.SetText(listBox1.SelectedItem.ToString());
			}
		}

		private void copyAllToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
				StringBuilder sb = new StringBuilder();

				for (int i = 0; i < listBox1.Items.Count; i++)
				{
					sb.AppendLine(listBox1.Items[i].ToString());
				}

				Clipboard.SetText(sb.ToString());
			}
		}

		private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			copyToolStripMenuItem.Enabled = listBox1.SelectedItems.Count > 0;
		}
	}
}
