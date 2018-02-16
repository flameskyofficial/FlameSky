namespace FlameSky
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseOtherTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.PanelToolbar = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Button();
            this.AddressBarPanel = new System.Windows.Forms.Panel();
            this.LoadingIndicator = new System.Windows.Forms.PictureBox();
            this.TabPages = new FarsiLibrary.Win.FATabStrip();
            this.tabStrip1 = new FarsiLibrary.Win.FATabStripItem();
            this.tabStripAdd = new FarsiLibrary.Win.FATabStripItem();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.BtnNextSearch = new System.Windows.Forms.Button();
            this.BtnPrevSearch = new System.Windows.Forms.Button();
            this.BtnCloseSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuStripDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTab.SuspendLayout();
            this.PanelToolbar.SuspendLayout();
            this.AddressBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).BeginInit();
            this.TabPages.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.MenuStripDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTab
            // 
            this.menuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCloseTab,
            this.menuCloseOtherTabs});
            this.menuStripTab.Name = "menuStripTab";
            this.menuStripTab.Size = new System.Drawing.Size(170, 48);
            // 
            // menuCloseTab
            // 
            this.menuCloseTab.Name = "menuCloseTab";
            this.menuCloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.menuCloseTab.Size = new System.Drawing.Size(169, 22);
            this.menuCloseTab.Text = "Close tab";
            this.menuCloseTab.Click += new System.EventHandler(this.menuCloseTab_Click);
            // 
            // menuCloseOtherTabs
            // 
            this.menuCloseOtherTabs.Name = "menuCloseOtherTabs";
            this.menuCloseOtherTabs.Size = new System.Drawing.Size(169, 22);
            this.menuCloseOtherTabs.Text = "Close other tabs";
            this.menuCloseOtherTabs.Click += new System.EventHandler(this.menuCloseOtherTabs_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRefresh.BackgroundImage = global::FlameSky.Properties.Resources.makefg__2_1;
            this.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnRefresh.Location = new System.Drawing.Point(54, 1);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(23, 23);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnStop.BackgroundImage = global::FlameSky.Properties.Resources.FlameSkyStopIcon;
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnStop.Location = new System.Drawing.Point(54, 1);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(23, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnForward.BackgroundImage")));
            this.BtnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForward.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnForward.Location = new System.Drawing.Point(25, 1);
            this.BtnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(23, 23);
            this.BtnForward.TabIndex = 1;
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.bForward_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBack.BackgroundImage")));
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnBack.Location = new System.Drawing.Point(3, 1);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(23, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtURL
            // 
            this.TxtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtURL.Location = new System.Drawing.Point(30, 2);
            this.TxtURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(793, 16);
            this.TxtURL.TabIndex = 5;
            this.TxtURL.Click += new System.EventHandler(this.txtUrl_Click);
            this.TxtURL.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.TxtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtURL_KeyDown);
            // 
            // PanelToolbar
            // 
            this.PanelToolbar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelToolbar.Controls.Add(this.Menu);
            this.PanelToolbar.Controls.Add(this.AddressBarPanel);
            this.PanelToolbar.Controls.Add(this.BtnForward);
            this.PanelToolbar.Controls.Add(this.BtnRefresh);
            this.PanelToolbar.Controls.Add(this.BtnBack);
            this.PanelToolbar.Controls.Add(this.BtnStop);
            this.PanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelToolbar.Location = new System.Drawing.Point(0, 0);
            this.PanelToolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelToolbar.Name = "PanelToolbar";
            this.PanelToolbar.Size = new System.Drawing.Size(934, 27);
            this.PanelToolbar.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.BackgroundImage = global::FlameSky.Properties.Resources.MenuIcon;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Menu.Location = new System.Drawing.Point(911, 1);
            this.Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(23, 23);
            this.Menu.TabIndex = 5;
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // AddressBarPanel
            // 
            this.AddressBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBarPanel.BackColor = System.Drawing.SystemColors.Window;
            this.AddressBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBarPanel.Controls.Add(this.LoadingIndicator);
            this.AddressBarPanel.Controls.Add(this.TxtURL);
            this.AddressBarPanel.Location = new System.Drawing.Point(83, 1);
            this.AddressBarPanel.Name = "AddressBarPanel";
            this.AddressBarPanel.Size = new System.Drawing.Size(828, 23);
            this.AddressBarPanel.TabIndex = 4;
            this.AddressBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddressBarPanel_Paint);
            // 
            // LoadingIndicator
            // 
            this.LoadingIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadingIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadingIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoadingIndicator.Location = new System.Drawing.Point(1, -1);
            this.LoadingIndicator.Name = "LoadingIndicator";
            this.LoadingIndicator.Size = new System.Drawing.Size(23, 23);
            this.LoadingIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadingIndicator.TabIndex = 0;
            this.LoadingIndicator.TabStop = false;
            // 
            // TabPages
            // 
            this.TabPages.ContextMenuStrip = this.menuStripTab;
            this.TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPages.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabStrip1,
            this.tabStripAdd});
            this.TabPages.Location = new System.Drawing.Point(0, 27);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedItem = this.tabStrip1;
            this.TabPages.Size = new System.Drawing.Size(934, 650);
            this.TabPages.TabIndex = 4;
            this.TabPages.Text = "faTabStrip1";
            this.TabPages.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.OnTabsChanged);
            this.TabPages.TabStripItemClosed += new System.EventHandler(this.OnTabClosed);
            this.TabPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPages_MouseClick);
            // 
            // tabStrip1
            // 
            this.tabStrip1.IsDrawn = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.Selected = true;
            this.tabStrip1.Size = new System.Drawing.Size(932, 620);
            this.tabStrip1.TabIndex = 0;
            this.tabStrip1.Title = "Loading...";
            this.tabStrip1.Changed += new System.EventHandler(this.tabStrip1_Changed);
            // 
            // tabStripAdd
            // 
            this.tabStripAdd.CanClose = false;
            this.tabStripAdd.IsDrawn = true;
            this.tabStripAdd.Name = "tabStripAdd";
            this.tabStripAdd.Size = new System.Drawing.Size(931, 601);
            this.tabStripAdd.TabIndex = 1;
            this.tabStripAdd.Title = "+";
            // 
            // PanelSearch
            // 
            this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.BtnNextSearch);
            this.PanelSearch.Controls.Add(this.BtnPrevSearch);
            this.PanelSearch.Controls.Add(this.BtnCloseSearch);
            this.PanelSearch.Controls.Add(this.TxtSearch);
            this.PanelSearch.Location = new System.Drawing.Point(3, 29);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(307, 40);
            this.PanelSearch.TabIndex = 9;
            this.PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSearch.ForeColor = System.Drawing.Color.White;
            this.BtnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
            this.BtnNextSearch.Location = new System.Drawing.Point(239, 4);
            this.BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNextSearch.Name = "BtnNextSearch";
            this.BtnNextSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnNextSearch.TabIndex = 9;
            this.BtnNextSearch.Tag = "Find next (Enter)";
            this.BtnNextSearch.UseVisualStyleBackColor = true;
            this.BtnNextSearch.Click += new System.EventHandler(this.BtnNextSearch_Click);
            // 
            // BtnPrevSearch
            // 
            this.BtnPrevSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevSearch.ForeColor = System.Drawing.Color.White;
            this.BtnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
            this.BtnPrevSearch.Location = new System.Drawing.Point(206, 4);
            this.BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPrevSearch.Name = "BtnPrevSearch";
            this.BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnPrevSearch.TabIndex = 8;
            this.BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
            this.BtnPrevSearch.UseVisualStyleBackColor = true;
            this.BtnPrevSearch.Click += new System.EventHandler(this.BtnPrevSearch_Click);
            // 
            // BtnCloseSearch
            // 
            this.BtnCloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCloseSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
            this.BtnCloseSearch.Location = new System.Drawing.Point(272, 4);
            this.BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCloseSearch.Name = "BtnCloseSearch";
            this.BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnCloseSearch.TabIndex = 7;
            this.BtnCloseSearch.Tag = "Close (Esc)";
            this.BtnCloseSearch.UseVisualStyleBackColor = true;
            this.BtnCloseSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(10, 6);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(181, 25);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 4000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // MenuStripDropDown
            // 
            this.MenuStripDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeTabToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.downloadsToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.developerToolsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuStripDropDown.Name = "contextMenuStrip1";
            this.MenuStripDropDown.Size = new System.Drawing.Size(195, 202);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Image = global::FlameSky.Properties.Resources.AddTabIcon;
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + T";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click_1);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Image = global::FlameSky.Properties.Resources.RemoveTabIcon;
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + W";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click_1);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Image = global::FlameSky.Properties.Resources.NewWindowIcon;
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click_1);
            // 
            // developerToolsToolStripMenuItem
            // 
            this.developerToolsToolStripMenuItem.Image = global::FlameSky.Properties.Resources.DeveloperToolsIcon;
            this.developerToolsToolStripMenuItem.Name = "developerToolsToolStripMenuItem";
            this.developerToolsToolStripMenuItem.ShortcutKeyDisplayString = "F 12";
            this.developerToolsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.developerToolsToolStripMenuItem.Text = "Developer Tools";
            this.developerToolsToolStripMenuItem.Click += new System.EventHandler(this.developerToolsToolStripMenuItem_Click_1);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::FlameSky.Properties.Resources.SettingsIcon;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click_1);
            // 
            // downloadsToolStripMenuItem
            // 
            this.downloadsToolStripMenuItem.Image = global::FlameSky.Properties.Resources.DownloadIcon;
            this.downloadsToolStripMenuItem.Name = "downloadsToolStripMenuItem";
            this.downloadsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.downloadsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.downloadsToolStripMenuItem.Text = "Downloads";
            this.downloadsToolStripMenuItem.Click += new System.EventHandler(this.downloadsToolStripMenuItem_Click_1);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Image = global::FlameSky.Properties.Resources.HistoryIcon;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 677);
            this.Controls.Add(this.TabPages);
            this.Controls.Add(this.PanelToolbar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
            this.menuStripTab.ResumeLayout(false);
            this.PanelToolbar.ResumeLayout(false);
            this.AddressBarPanel.ResumeLayout(false);
            this.AddressBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).EndInit();
            this.TabPages.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.MenuStripDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

		private FarsiLibrary.Win.FATabStrip TabPages;
        private FarsiLibrary.Win.FATabStripItem tabStrip1;
        private FarsiLibrary.Win.FATabStripItem tabStripAdd;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip menuStripTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseOtherTabs;
		private System.Windows.Forms.Button BtnForward;
		private System.Windows.Forms.Button BtnBack;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.TextBox TxtURL;
		private System.Windows.Forms.Panel PanelToolbar;
		private System.Windows.Forms.Panel PanelSearch;
		private System.Windows.Forms.TextBox TxtSearch;
		private System.Windows.Forms.Button BtnCloseSearch;
		private System.Windows.Forms.Button BtnPrevSearch;
		private System.Windows.Forms.Button BtnNextSearch;
        private System.Windows.Forms.Panel AddressBarPanel;
        private System.Windows.Forms.PictureBox LoadingIndicator;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.ContextMenuStrip MenuStripDropDown;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

