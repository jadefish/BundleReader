namespace BundleReader
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel_main = new System.Windows.Forms.Panel();
			this.panel_middle = new System.Windows.Forms.Panel();
			this.label_serverIcons = new System.Windows.Forms.Label();
			this.label_localIcons = new System.Windows.Forms.Label();
			this.label_buildVersion = new System.Windows.Forms.Label();
			this.label_getInfoVersion = new System.Windows.Forms.Label();
			this.label_shortVersion = new System.Windows.Forms.Label();
			this.label_bundleVersion = new System.Windows.Forms.Label();
			this.label_mudVersion = new System.Windows.Forms.Label();
			this.label_displayName = new System.Windows.Forms.Label();
			this.label_fileName = new System.Windows.Forms.Label();
			this.panel_right = new System.Windows.Forms.Panel();
			this.modernButton_editListing = new ModernStuff.Controls.ModernButton();
			this.modernButton_saveLangauges = new ModernStuff.Controls.ModernButton();
			this.label_serverLanguages = new System.Windows.Forms.Label();
			this.label_localLanguages = new System.Windows.Forms.Label();
			this.label_MUMatch = new System.Windows.Forms.Label();
			this.label_MUIDVersion = new System.Windows.Forms.Label();
			this.label_architectureOS = new System.Windows.Forms.Label();
			this.label_sparkleURL = new System.Windows.Forms.Label();
			this.label_bundleID = new System.Windows.Forms.Label();
			this.panel_left = new System.Windows.Forms.Panel();
			this.modernButton_upload = new ModernStuff.Controls.ModernButton();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exportFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.plistInspectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuItem_darkTheme = new System.Windows.Forms.ToolStripMenuItem();
			this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mUHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mUContentHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.queueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel_overlay = new System.Windows.Forms.Panel();
			this.label_overlay = new System.Windows.Forms.Label();
			this.menuItem_sendServerRequests = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox_serverIcons = new BundleReader.TextBoxPlus();
			this.textBox_localIcons = new BundleReader.TextBoxPlus();
			this.textBox_buildVersion = new BundleReader.TextBoxPlus();
			this.textBox_getInfoVersion = new BundleReader.TextBoxPlus();
			this.textBox_shortVersion = new BundleReader.TextBoxPlus();
			this.textBox_bundleVersion = new BundleReader.TextBoxPlus();
			this.textBox_mudVersion = new BundleReader.TextBoxPlus();
			this.textBox_displayName = new BundleReader.TextBoxPlus();
			this.textBox_fileName = new BundleReader.TextBoxPlus();
			this.textBox_serverLanguages = new BundleReader.TextBoxPlus();
			this.textBox_localLanguages = new BundleReader.TextBoxPlus();
			this.textBox_MUMatch = new BundleReader.TextBoxPlus();
			this.textBox_MUIDVersion = new BundleReader.TextBoxPlus();
			this.textBox_architectureOS = new BundleReader.TextBoxPlus();
			this.textBox_sparkleUrl = new BundleReader.TextBoxPlus();
			this.textBox_bundleID = new BundleReader.TextBoxPlus();
			this.pictureBoxLink_appIcon = new BundleReader.PictureBoxLink();
			this.panel_main.SuspendLayout();
			this.panel_middle.SuspendLayout();
			this.panel_right.SuspendLayout();
			this.panel_left.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.panel_overlay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink_appIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_main
			// 
			this.panel_main.Controls.Add(this.panel_middle);
			this.panel_main.Controls.Add(this.panel_right);
			this.panel_main.Controls.Add(this.panel_left);
			this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_main.Location = new System.Drawing.Point(4, 44);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(795, 221);
			this.panel_main.TabIndex = 0;
			// 
			// panel_middle
			// 
			this.panel_middle.Controls.Add(this.textBox_serverIcons);
			this.panel_middle.Controls.Add(this.textBox_localIcons);
			this.panel_middle.Controls.Add(this.textBox_buildVersion);
			this.panel_middle.Controls.Add(this.textBox_getInfoVersion);
			this.panel_middle.Controls.Add(this.textBox_shortVersion);
			this.panel_middle.Controls.Add(this.textBox_bundleVersion);
			this.panel_middle.Controls.Add(this.textBox_mudVersion);
			this.panel_middle.Controls.Add(this.textBox_displayName);
			this.panel_middle.Controls.Add(this.textBox_fileName);
			this.panel_middle.Controls.Add(this.label_serverIcons);
			this.panel_middle.Controls.Add(this.label_localIcons);
			this.panel_middle.Controls.Add(this.label_buildVersion);
			this.panel_middle.Controls.Add(this.label_getInfoVersion);
			this.panel_middle.Controls.Add(this.label_shortVersion);
			this.panel_middle.Controls.Add(this.label_bundleVersion);
			this.panel_middle.Controls.Add(this.label_mudVersion);
			this.panel_middle.Controls.Add(this.label_displayName);
			this.panel_middle.Controls.Add(this.label_fileName);
			this.panel_middle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_middle.Location = new System.Drawing.Point(140, 0);
			this.panel_middle.Name = "panel_middle";
			this.panel_middle.Size = new System.Drawing.Size(311, 221);
			this.panel_middle.TabIndex = 2;
			// 
			// label_serverIcons
			// 
			this.label_serverIcons.Location = new System.Drawing.Point(0, 165);
			this.label_serverIcons.Name = "label_serverIcons";
			this.label_serverIcons.Size = new System.Drawing.Size(105, 20);
			this.label_serverIcons.TabIndex = 10;
			this.label_serverIcons.Tag = "header";
			this.label_serverIcons.Text = "Server icon size";
			// 
			// label_localIcons
			// 
			this.label_localIcons.Location = new System.Drawing.Point(0, 145);
			this.label_localIcons.Name = "label_localIcons";
			this.label_localIcons.Size = new System.Drawing.Size(105, 20);
			this.label_localIcons.TabIndex = 9;
			this.label_localIcons.Tag = "header";
			this.label_localIcons.Text = "Local icon size";
			// 
			// label_buildVersion
			// 
			this.label_buildVersion.Location = new System.Drawing.Point(0, 125);
			this.label_buildVersion.Name = "label_buildVersion";
			this.label_buildVersion.Size = new System.Drawing.Size(105, 20);
			this.label_buildVersion.TabIndex = 8;
			this.label_buildVersion.Tag = "header";
			this.label_buildVersion.Text = "BuildVersion";
			// 
			// label_getInfoVersion
			// 
			this.label_getInfoVersion.Location = new System.Drawing.Point(0, 105);
			this.label_getInfoVersion.Name = "label_getInfoVersion";
			this.label_getInfoVersion.Size = new System.Drawing.Size(105, 20);
			this.label_getInfoVersion.TabIndex = 7;
			this.label_getInfoVersion.Tag = "header";
			this.label_getInfoVersion.Text = "Get Info version";
			// 
			// label_shortVersion
			// 
			this.label_shortVersion.Location = new System.Drawing.Point(0, 85);
			this.label_shortVersion.Name = "label_shortVersion";
			this.label_shortVersion.Size = new System.Drawing.Size(105, 20);
			this.label_shortVersion.TabIndex = 6;
			this.label_shortVersion.Tag = "header";
			this.label_shortVersion.Text = "Short version";
			// 
			// label_bundleVersion
			// 
			this.label_bundleVersion.Location = new System.Drawing.Point(0, 65);
			this.label_bundleVersion.Name = "label_bundleVersion";
			this.label_bundleVersion.Size = new System.Drawing.Size(105, 20);
			this.label_bundleVersion.TabIndex = 5;
			this.label_bundleVersion.Tag = "header";
			this.label_bundleVersion.Text = "Bundle version";
			// 
			// label_mudVersion
			// 
			this.label_mudVersion.Location = new System.Drawing.Point(0, 45);
			this.label_mudVersion.Name = "label_mudVersion";
			this.label_mudVersion.Size = new System.Drawing.Size(105, 20);
			this.label_mudVersion.TabIndex = 4;
			this.label_mudVersion.Tag = "header";
			this.label_mudVersion.Text = "MUD version";
			// 
			// label_displayName
			// 
			this.label_displayName.Location = new System.Drawing.Point(0, 25);
			this.label_displayName.Name = "label_displayName";
			this.label_displayName.Size = new System.Drawing.Size(105, 20);
			this.label_displayName.TabIndex = 3;
			this.label_displayName.Tag = "header";
			this.label_displayName.Text = "Display name";
			// 
			// label_fileName
			// 
			this.label_fileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_fileName.Location = new System.Drawing.Point(0, 5);
			this.label_fileName.Name = "label_fileName";
			this.label_fileName.Size = new System.Drawing.Size(105, 20);
			this.label_fileName.TabIndex = 2;
			this.label_fileName.Tag = "header";
			this.label_fileName.Text = "File name";
			// 
			// panel_right
			// 
			this.panel_right.Controls.Add(this.modernButton_editListing);
			this.panel_right.Controls.Add(this.modernButton_saveLangauges);
			this.panel_right.Controls.Add(this.textBox_serverLanguages);
			this.panel_right.Controls.Add(this.textBox_localLanguages);
			this.panel_right.Controls.Add(this.textBox_MUMatch);
			this.panel_right.Controls.Add(this.textBox_MUIDVersion);
			this.panel_right.Controls.Add(this.textBox_architectureOS);
			this.panel_right.Controls.Add(this.textBox_sparkleUrl);
			this.panel_right.Controls.Add(this.textBox_bundleID);
			this.panel_right.Controls.Add(this.label_serverLanguages);
			this.panel_right.Controls.Add(this.label_localLanguages);
			this.panel_right.Controls.Add(this.label_MUMatch);
			this.panel_right.Controls.Add(this.label_MUIDVersion);
			this.panel_right.Controls.Add(this.label_architectureOS);
			this.panel_right.Controls.Add(this.label_sparkleURL);
			this.panel_right.Controls.Add(this.label_bundleID);
			this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel_right.Location = new System.Drawing.Point(451, 0);
			this.panel_right.Name = "panel_right";
			this.panel_right.Size = new System.Drawing.Size(344, 221);
			this.panel_right.TabIndex = 1;
			// 
			// modernButton_editListing
			// 
			this.modernButton_editListing.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.modernButton_editListing.Location = new System.Drawing.Point(280, 85);
			this.modernButton_editListing.Name = "modernButton_editListing";
			this.modernButton_editListing.Size = new System.Drawing.Size(60, 20);
			this.modernButton_editListing.TabIndex = 36;
			this.modernButton_editListing.Text = "Edit";
			// 
			// modernButton_saveLangauges
			// 
			this.modernButton_saveLangauges.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.modernButton_saveLangauges.Location = new System.Drawing.Point(210, 150);
			this.modernButton_saveLangauges.Name = "modernButton_saveLangauges";
			this.modernButton_saveLangauges.Size = new System.Drawing.Size(130, 23);
			this.modernButton_saveLangauges.TabIndex = 34;
			this.modernButton_saveLangauges.Text = "Save languages";
			// 
			// label_serverLanguages
			// 
			this.label_serverLanguages.Location = new System.Drawing.Point(0, 125);
			this.label_serverLanguages.Name = "label_serverLanguages";
			this.label_serverLanguages.Size = new System.Drawing.Size(105, 20);
			this.label_serverLanguages.TabIndex = 26;
			this.label_serverLanguages.Tag = "header";
			this.label_serverLanguages.Text = "Server languages";
			// 
			// label_localLanguages
			// 
			this.label_localLanguages.Location = new System.Drawing.Point(0, 105);
			this.label_localLanguages.Name = "label_localLanguages";
			this.label_localLanguages.Size = new System.Drawing.Size(105, 20);
			this.label_localLanguages.TabIndex = 25;
			this.label_localLanguages.Tag = "header";
			this.label_localLanguages.Text = "Local languages";
			// 
			// label_MUMatch
			// 
			this.label_MUMatch.Location = new System.Drawing.Point(0, 85);
			this.label_MUMatch.Name = "label_MUMatch";
			this.label_MUMatch.Size = new System.Drawing.Size(105, 20);
			this.label_MUMatch.TabIndex = 24;
			this.label_MUMatch.Tag = "header";
			this.label_MUMatch.Text = "MU match";
			// 
			// label_MUIDVersion
			// 
			this.label_MUIDVersion.Location = new System.Drawing.Point(0, 65);
			this.label_MUIDVersion.Name = "label_MUIDVersion";
			this.label_MUIDVersion.Size = new System.Drawing.Size(105, 20);
			this.label_MUIDVersion.TabIndex = 23;
			this.label_MUIDVersion.Tag = "header";
			this.label_MUIDVersion.Text = "MU ID && version";
			// 
			// label_architectureOS
			// 
			this.label_architectureOS.Location = new System.Drawing.Point(0, 45);
			this.label_architectureOS.Name = "label_architectureOS";
			this.label_architectureOS.Size = new System.Drawing.Size(105, 20);
			this.label_architectureOS.TabIndex = 22;
			this.label_architectureOS.Tag = "header";
			this.label_architectureOS.Text = "Architecture/OS";
			// 
			// label_sparkleURL
			// 
			this.label_sparkleURL.Location = new System.Drawing.Point(0, 25);
			this.label_sparkleURL.Name = "label_sparkleURL";
			this.label_sparkleURL.Size = new System.Drawing.Size(105, 20);
			this.label_sparkleURL.TabIndex = 21;
			this.label_sparkleURL.Tag = "header";
			this.label_sparkleURL.Text = "Sparkle URL";
			// 
			// label_bundleID
			// 
			this.label_bundleID.Location = new System.Drawing.Point(0, 5);
			this.label_bundleID.Name = "label_bundleID";
			this.label_bundleID.Size = new System.Drawing.Size(105, 20);
			this.label_bundleID.TabIndex = 20;
			this.label_bundleID.Tag = "header";
			this.label_bundleID.Text = "Bundle ID";
			// 
			// panel_left
			// 
			this.panel_left.Controls.Add(this.pictureBoxLink_appIcon);
			this.panel_left.Controls.Add(this.modernButton_upload);
			this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_left.Location = new System.Drawing.Point(0, 0);
			this.panel_left.Name = "panel_left";
			this.panel_left.Size = new System.Drawing.Size(140, 221);
			this.panel_left.TabIndex = 0;
			// 
			// modernButton_upload
			// 
			this.modernButton_upload.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.modernButton_upload.Enabled = false;
			this.modernButton_upload.Location = new System.Drawing.Point(10, 140);
			this.modernButton_upload.Name = "modernButton_upload";
			this.modernButton_upload.Size = new System.Drawing.Size(120, 23);
			this.modernButton_upload.TabIndex = 1;
			this.modernButton_upload.Text = "Upload";
			// 
			// menuStrip
			// 
			this.menuStrip.AutoSize = false;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(4, 24);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
			this.menuStrip.Size = new System.Drawing.Size(795, 20);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportFieldsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Enabled = false;
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
			// 
			// exportFieldsToolStripMenuItem
			// 
			this.exportFieldsToolStripMenuItem.Enabled = false;
			this.exportFieldsToolStripMenuItem.Name = "exportFieldsToolStripMenuItem";
			this.exportFieldsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.exportFieldsToolStripMenuItem.Text = "&Export fields...";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFieldsToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// copyFieldsToolStripMenuItem
			// 
			this.copyFieldsToolStripMenuItem.Enabled = false;
			this.copyFieldsToolStripMenuItem.Name = "copyFieldsToolStripMenuItem";
			this.copyFieldsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.copyFieldsToolStripMenuItem.Text = "&Copy fields";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plistInspectorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.menuItem_darkTheme,
            this.menuItem_sendServerRequests});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// plistInspectorToolStripMenuItem
			// 
			this.plistInspectorToolStripMenuItem.Name = "plistInspectorToolStripMenuItem";
			this.plistInspectorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.plistInspectorToolStripMenuItem.Text = "plist Inspector";
			this.plistInspectorToolStripMenuItem.Click += new System.EventHandler(this.plistInspectorToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
			// 
			// menuItem_darkTheme
			// 
			this.menuItem_darkTheme.CheckOnClick = true;
			this.menuItem_darkTheme.Name = "menuItem_darkTheme";
			this.menuItem_darkTheme.Size = new System.Drawing.Size(181, 22);
			this.menuItem_darkTheme.Text = "Dark theme";
			this.menuItem_darkTheme.Click += new System.EventHandler(this.toggleThemeToolStripMenuItem_Click);
			// 
			// linksToolStripMenuItem
			// 
			this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUHomeToolStripMenuItem,
            this.mUContentHomeToolStripMenuItem,
            this.queueToolStripMenuItem});
			this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
			this.linksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.linksToolStripMenuItem.Text = "&Links";
			// 
			// mUHomeToolStripMenuItem
			// 
			this.mUHomeToolStripMenuItem.Name = "mUHomeToolStripMenuItem";
			this.mUHomeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.mUHomeToolStripMenuItem.Text = "&MU home";
			this.mUHomeToolStripMenuItem.Click += new System.EventHandler(this.mUHomeToolStripMenuItem_Click);
			// 
			// mUContentHomeToolStripMenuItem
			// 
			this.mUContentHomeToolStripMenuItem.Name = "mUContentHomeToolStripMenuItem";
			this.mUContentHomeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.mUContentHomeToolStripMenuItem.Text = "MU&Content home";
			this.mUContentHomeToolStripMenuItem.Click += new System.EventHandler(this.mUContentHomeToolStripMenuItem_Click);
			// 
			// queueToolStripMenuItem
			// 
			this.queueToolStripMenuItem.Name = "queueToolStripMenuItem";
			this.queueToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.queueToolStripMenuItem.Text = "&Queue";
			this.queueToolStripMenuItem.Click += new System.EventHandler(this.queueToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.contentsToolStripMenuItem.Text = "&Knowledge base...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			// 
			// panel_overlay
			// 
			this.panel_overlay.Controls.Add(this.label_overlay);
			this.panel_overlay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_overlay.Location = new System.Drawing.Point(4, 24);
			this.panel_overlay.Name = "panel_overlay";
			this.panel_overlay.Padding = new System.Windows.Forms.Padding(5);
			this.panel_overlay.Size = new System.Drawing.Size(795, 241);
			this.panel_overlay.TabIndex = 2;
			// 
			// label_overlay
			// 
			this.label_overlay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_overlay.Location = new System.Drawing.Point(5, 5);
			this.label_overlay.Name = "label_overlay";
			this.label_overlay.Size = new System.Drawing.Size(785, 231);
			this.label_overlay.TabIndex = 1;
			this.label_overlay.Text = "Drop an app or bundle on me!";
			this.label_overlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuItem_sendServerRequests
			// 
			this.menuItem_sendServerRequests.Checked = true;
			this.menuItem_sendServerRequests.CheckOnClick = true;
			this.menuItem_sendServerRequests.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuItem_sendServerRequests.Name = "menuItem_sendServerRequests";
			this.menuItem_sendServerRequests.Size = new System.Drawing.Size(181, 22);
			this.menuItem_sendServerRequests.Text = "Send server requests";
			// 
			// textBox_serverIcons
			// 
			this.textBox_serverIcons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_serverIcons.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_serverIcons.DetectUrls = false;
			this.textBox_serverIcons.Location = new System.Drawing.Point(105, 165);
			this.textBox_serverIcons.Multiline = false;
			this.textBox_serverIcons.Name = "textBox_serverIcons";
			this.textBox_serverIcons.ReadOnly = true;
			this.textBox_serverIcons.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_serverIcons.Size = new System.Drawing.Size(190, 20);
			this.textBox_serverIcons.TabIndex = 19;
			this.textBox_serverIcons.Text = "-";
			// 
			// textBox_localIcons
			// 
			this.textBox_localIcons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_localIcons.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_localIcons.DetectUrls = false;
			this.textBox_localIcons.Location = new System.Drawing.Point(105, 145);
			this.textBox_localIcons.Multiline = false;
			this.textBox_localIcons.Name = "textBox_localIcons";
			this.textBox_localIcons.ReadOnly = true;
			this.textBox_localIcons.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_localIcons.Size = new System.Drawing.Size(190, 20);
			this.textBox_localIcons.TabIndex = 18;
			this.textBox_localIcons.Text = "-";
			// 
			// textBox_buildVersion
			// 
			this.textBox_buildVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_buildVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_buildVersion.DetectUrls = false;
			this.textBox_buildVersion.Location = new System.Drawing.Point(105, 125);
			this.textBox_buildVersion.Multiline = false;
			this.textBox_buildVersion.Name = "textBox_buildVersion";
			this.textBox_buildVersion.ReadOnly = true;
			this.textBox_buildVersion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_buildVersion.Size = new System.Drawing.Size(190, 20);
			this.textBox_buildVersion.TabIndex = 17;
			this.textBox_buildVersion.Text = "-";
			// 
			// textBox_getInfoVersion
			// 
			this.textBox_getInfoVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_getInfoVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_getInfoVersion.DetectUrls = false;
			this.textBox_getInfoVersion.Location = new System.Drawing.Point(105, 105);
			this.textBox_getInfoVersion.Multiline = false;
			this.textBox_getInfoVersion.Name = "textBox_getInfoVersion";
			this.textBox_getInfoVersion.ReadOnly = true;
			this.textBox_getInfoVersion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_getInfoVersion.Size = new System.Drawing.Size(190, 20);
			this.textBox_getInfoVersion.TabIndex = 16;
			this.textBox_getInfoVersion.Text = "-";
			// 
			// textBox_shortVersion
			// 
			this.textBox_shortVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_shortVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_shortVersion.DetectUrls = false;
			this.textBox_shortVersion.Location = new System.Drawing.Point(105, 85);
			this.textBox_shortVersion.Multiline = false;
			this.textBox_shortVersion.Name = "textBox_shortVersion";
			this.textBox_shortVersion.ReadOnly = true;
			this.textBox_shortVersion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_shortVersion.Size = new System.Drawing.Size(190, 20);
			this.textBox_shortVersion.TabIndex = 15;
			this.textBox_shortVersion.Text = "-";
			// 
			// textBox_bundleVersion
			// 
			this.textBox_bundleVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_bundleVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_bundleVersion.DetectUrls = false;
			this.textBox_bundleVersion.Location = new System.Drawing.Point(105, 65);
			this.textBox_bundleVersion.Multiline = false;
			this.textBox_bundleVersion.Name = "textBox_bundleVersion";
			this.textBox_bundleVersion.ReadOnly = true;
			this.textBox_bundleVersion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_bundleVersion.Size = new System.Drawing.Size(190, 20);
			this.textBox_bundleVersion.TabIndex = 14;
			this.textBox_bundleVersion.Text = "-";
			// 
			// textBox_mudVersion
			// 
			this.textBox_mudVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_mudVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_mudVersion.DetectUrls = false;
			this.textBox_mudVersion.Location = new System.Drawing.Point(105, 45);
			this.textBox_mudVersion.Multiline = false;
			this.textBox_mudVersion.Name = "textBox_mudVersion";
			this.textBox_mudVersion.ReadOnly = true;
			this.textBox_mudVersion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_mudVersion.Size = new System.Drawing.Size(190, 20);
			this.textBox_mudVersion.TabIndex = 13;
			this.textBox_mudVersion.Text = "-";
			// 
			// textBox_displayName
			// 
			this.textBox_displayName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_displayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_displayName.DetectUrls = false;
			this.textBox_displayName.Location = new System.Drawing.Point(105, 25);
			this.textBox_displayName.Multiline = false;
			this.textBox_displayName.Name = "textBox_displayName";
			this.textBox_displayName.ReadOnly = true;
			this.textBox_displayName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_displayName.Size = new System.Drawing.Size(190, 20);
			this.textBox_displayName.TabIndex = 12;
			this.textBox_displayName.Text = "-";
			// 
			// textBox_fileName
			// 
			this.textBox_fileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_fileName.DetectUrls = false;
			this.textBox_fileName.Location = new System.Drawing.Point(105, 5);
			this.textBox_fileName.Multiline = false;
			this.textBox_fileName.Name = "textBox_fileName";
			this.textBox_fileName.ReadOnly = true;
			this.textBox_fileName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_fileName.Size = new System.Drawing.Size(190, 20);
			this.textBox_fileName.TabIndex = 11;
			this.textBox_fileName.Text = "-";
			// 
			// textBox_serverLanguages
			// 
			this.textBox_serverLanguages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_serverLanguages.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_serverLanguages.DetectUrls = false;
			this.textBox_serverLanguages.Location = new System.Drawing.Point(105, 125);
			this.textBox_serverLanguages.Multiline = false;
			this.textBox_serverLanguages.Name = "textBox_serverLanguages";
			this.textBox_serverLanguages.ReadOnly = true;
			this.textBox_serverLanguages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_serverLanguages.Size = new System.Drawing.Size(235, 20);
			this.textBox_serverLanguages.TabIndex = 33;
			this.textBox_serverLanguages.Text = "-";
			// 
			// textBox_localLanguages
			// 
			this.textBox_localLanguages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_localLanguages.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_localLanguages.DetectUrls = false;
			this.textBox_localLanguages.Location = new System.Drawing.Point(105, 105);
			this.textBox_localLanguages.Multiline = false;
			this.textBox_localLanguages.Name = "textBox_localLanguages";
			this.textBox_localLanguages.ReadOnly = true;
			this.textBox_localLanguages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_localLanguages.Size = new System.Drawing.Size(235, 20);
			this.textBox_localLanguages.TabIndex = 32;
			this.textBox_localLanguages.Text = "-";
			// 
			// textBox_MUMatch
			// 
			this.textBox_MUMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_MUMatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_MUMatch.Location = new System.Drawing.Point(105, 85);
			this.textBox_MUMatch.Multiline = false;
			this.textBox_MUMatch.Name = "textBox_MUMatch";
			this.textBox_MUMatch.ReadOnly = true;
			this.textBox_MUMatch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_MUMatch.Size = new System.Drawing.Size(175, 20);
			this.textBox_MUMatch.TabIndex = 31;
			this.textBox_MUMatch.Text = "-";
			// 
			// textBox_MUIDVersion
			// 
			this.textBox_MUIDVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_MUIDVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_MUIDVersion.DetectUrls = false;
			this.textBox_MUIDVersion.Location = new System.Drawing.Point(105, 65);
			this.textBox_MUIDVersion.Multiline = false;
			this.textBox_MUIDVersion.Name = "textBox_MUIDVersion";
			this.textBox_MUIDVersion.ReadOnly = true;
			this.textBox_MUIDVersion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_MUIDVersion.Size = new System.Drawing.Size(235, 20);
			this.textBox_MUIDVersion.TabIndex = 30;
			this.textBox_MUIDVersion.Text = "-";
			// 
			// textBox_architectureOS
			// 
			this.textBox_architectureOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_architectureOS.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_architectureOS.DetectUrls = false;
			this.textBox_architectureOS.Location = new System.Drawing.Point(105, 45);
			this.textBox_architectureOS.Multiline = false;
			this.textBox_architectureOS.Name = "textBox_architectureOS";
			this.textBox_architectureOS.ReadOnly = true;
			this.textBox_architectureOS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_architectureOS.Size = new System.Drawing.Size(235, 20);
			this.textBox_architectureOS.TabIndex = 29;
			this.textBox_architectureOS.Text = "-";
			// 
			// textBox_sparkleUrl
			// 
			this.textBox_sparkleUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_sparkleUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_sparkleUrl.Location = new System.Drawing.Point(105, 25);
			this.textBox_sparkleUrl.Multiline = false;
			this.textBox_sparkleUrl.Name = "textBox_sparkleUrl";
			this.textBox_sparkleUrl.ReadOnly = true;
			this.textBox_sparkleUrl.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_sparkleUrl.Size = new System.Drawing.Size(235, 20);
			this.textBox_sparkleUrl.TabIndex = 28;
			this.textBox_sparkleUrl.Text = "-";
			// 
			// textBox_bundleID
			// 
			this.textBox_bundleID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.textBox_bundleID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_bundleID.DetectUrls = false;
			this.textBox_bundleID.Location = new System.Drawing.Point(105, 5);
			this.textBox_bundleID.Multiline = false;
			this.textBox_bundleID.Name = "textBox_bundleID";
			this.textBox_bundleID.ReadOnly = true;
			this.textBox_bundleID.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox_bundleID.Size = new System.Drawing.Size(235, 20);
			this.textBox_bundleID.TabIndex = 27;
			this.textBox_bundleID.Text = "-";
			// 
			// pictureBoxLink_appIcon
			// 
			this.pictureBoxLink_appIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxLink_appIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxLink_appIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxLink_appIcon.Location = new System.Drawing.Point(5, 5);
			this.pictureBoxLink_appIcon.Name = "pictureBoxLink_appIcon";
			this.pictureBoxLink_appIcon.Size = new System.Drawing.Size(130, 130);
			this.pictureBoxLink_appIcon.TabIndex = 2;
			this.pictureBoxLink_appIcon.TabStop = false;
			this.pictureBoxLink_appIcon.Click += new System.EventHandler(this.pictureBoxLink_appIcon_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(803, 269);
			this.Controls.Add(this.panel_main);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.panel_overlay);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(4, 24, 4, 4);
			this.Text = "BundleReader";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
			this.panel_main.ResumeLayout(false);
			this.panel_middle.ResumeLayout(false);
			this.panel_right.ResumeLayout(false);
			this.panel_left.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panel_overlay.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLink_appIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_main;
		private System.Windows.Forms.Panel panel_middle;
		private TextBoxPlus textBox_fileName;
		private System.Windows.Forms.Label label_serverIcons;
		private System.Windows.Forms.Label label_localIcons;
		private System.Windows.Forms.Label label_buildVersion;
		private System.Windows.Forms.Label label_getInfoVersion;
		private System.Windows.Forms.Label label_shortVersion;
		private System.Windows.Forms.Label label_bundleVersion;
		private System.Windows.Forms.Label label_mudVersion;
		private System.Windows.Forms.Label label_displayName;
		private System.Windows.Forms.Label label_fileName;
		private System.Windows.Forms.Panel panel_right;
		private System.Windows.Forms.Panel panel_left;
		private ModernStuff.Controls.ModernButton modernButton_upload;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private TextBoxPlus textBox_serverIcons;
		private TextBoxPlus textBox_localIcons;
		private TextBoxPlus textBox_buildVersion;
		private TextBoxPlus textBox_getInfoVersion;
		private TextBoxPlus textBox_shortVersion;
		private TextBoxPlus textBox_bundleVersion;
		private TextBoxPlus textBox_mudVersion;
		private TextBoxPlus textBox_displayName;
		private ModernStuff.Controls.ModernButton modernButton_editListing;
		private ModernStuff.Controls.ModernButton modernButton_saveLangauges;
		private TextBoxPlus textBox_serverLanguages;
		private TextBoxPlus textBox_localLanguages;
		private TextBoxPlus textBox_MUMatch;
		private TextBoxPlus textBox_MUIDVersion;
		private TextBoxPlus textBox_architectureOS;
		private TextBoxPlus textBox_sparkleUrl;
		private TextBoxPlus textBox_bundleID;
		private System.Windows.Forms.Label label_serverLanguages;
		private System.Windows.Forms.Label label_localLanguages;
		private System.Windows.Forms.Label label_MUMatch;
		private System.Windows.Forms.Label label_MUIDVersion;
		private System.Windows.Forms.Label label_architectureOS;
		private System.Windows.Forms.Label label_sparkleURL;
		private System.Windows.Forms.Label label_bundleID;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportFieldsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem copyFieldsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem plistInspectorToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mUHomeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mUContentHomeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem queueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuItem_darkTheme;
		private PictureBoxLink pictureBoxLink_appIcon;
		private System.Windows.Forms.Panel panel_overlay;
		private System.Windows.Forms.Label label_overlay;
		private System.Windows.Forms.ToolStripMenuItem menuItem_sendServerRequests;
	}
}

