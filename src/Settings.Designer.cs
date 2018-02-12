namespace FlameSky
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SettingsScholar = new System.Windows.Forms.RadioButton();
            this.SettingsYouTube = new System.Windows.Forms.RadioButton();
            this.SettingsBing = new System.Windows.Forms.RadioButton();
            this.SettingsGoogle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SettingsHomepage = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HideSplashScreenOption = new System.Windows.Forms.RadioButton();
            this.ShowSplashScreenOption = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.docsWorkModeenabled = new System.Windows.Forms.RadioButton();
            this.docksWorkModedisabled = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FlameSky.Properties.Resources.FlameSkyLogo;
            this.pictureBox2.Location = new System.Drawing.Point(875, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 340);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "*These settings will be in effect once you restart the entire web browser";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SettingsScholar);
            this.groupBox2.Controls.Add(this.SettingsYouTube);
            this.groupBox2.Controls.Add(this.SettingsBing);
            this.groupBox2.Controls.Add(this.SettingsGoogle);
            this.groupBox2.Location = new System.Drawing.Point(7, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Engine";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SettingsScholar
            // 
            this.SettingsScholar.AutoSize = true;
            this.SettingsScholar.Location = new System.Drawing.Point(143, 52);
            this.SettingsScholar.Name = "SettingsScholar";
            this.SettingsScholar.Size = new System.Drawing.Size(98, 17);
            this.SettingsScholar.TabIndex = 4;
            this.SettingsScholar.TabStop = true;
            this.SettingsScholar.Text = "Google Scholar";
            this.SettingsScholar.UseVisualStyleBackColor = true;
            this.SettingsScholar.CheckedChanged += new System.EventHandler(this.SettingsScholar_CheckedChanged);
            // 
            // SettingsYouTube
            // 
            this.SettingsYouTube.AutoSize = true;
            this.SettingsYouTube.Location = new System.Drawing.Point(143, 29);
            this.SettingsYouTube.Name = "SettingsYouTube";
            this.SettingsYouTube.Size = new System.Drawing.Size(69, 17);
            this.SettingsYouTube.TabIndex = 3;
            this.SettingsYouTube.TabStop = true;
            this.SettingsYouTube.Text = "YouTube";
            this.SettingsYouTube.UseVisualStyleBackColor = true;
            this.SettingsYouTube.CheckedChanged += new System.EventHandler(this.SettingsYoutube_CheckedChanged);
            // 
            // SettingsBing
            // 
            this.SettingsBing.AutoSize = true;
            this.SettingsBing.Location = new System.Drawing.Point(14, 52);
            this.SettingsBing.Name = "SettingsBing";
            this.SettingsBing.Size = new System.Drawing.Size(46, 17);
            this.SettingsBing.TabIndex = 1;
            this.SettingsBing.TabStop = true;
            this.SettingsBing.Text = "Bing";
            this.SettingsBing.UseVisualStyleBackColor = true;
            this.SettingsBing.CheckedChanged += new System.EventHandler(this.SettingsBing_CheckedChanged);
            // 
            // SettingsGoogle
            // 
            this.SettingsGoogle.AutoSize = true;
            this.SettingsGoogle.Location = new System.Drawing.Point(14, 29);
            this.SettingsGoogle.Name = "SettingsGoogle";
            this.SettingsGoogle.Size = new System.Drawing.Size(59, 17);
            this.SettingsGoogle.TabIndex = 0;
            this.SettingsGoogle.TabStop = true;
            this.SettingsGoogle.Text = "Google";
            this.SettingsGoogle.UseVisualStyleBackColor = true;
            this.SettingsGoogle.CheckedChanged += new System.EventHandler(this.SettingsGoogle_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SettingsHomepage);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Homepage";
            // 
            // SettingsHomepage
            // 
            this.SettingsHomepage.Location = new System.Drawing.Point(15, 33);
            this.SettingsHomepage.Name = "SettingsHomepage";
            this.SettingsHomepage.Size = new System.Drawing.Size(862, 20);
            this.SettingsHomepage.TabIndex = 0;
            this.SettingsHomepage.TextChanged += new System.EventHandler(this.SettingsHomepage_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.HideSplashScreenOption);
            this.groupBox3.Controls.Add(this.ShowSplashScreenOption);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(7, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Splash Screen";
            // 
            // HideSplashScreenOption
            // 
            this.HideSplashScreenOption.AutoSize = true;
            this.HideSplashScreenOption.Location = new System.Drawing.Point(18, 51);
            this.HideSplashScreenOption.Name = "HideSplashScreenOption";
            this.HideSplashScreenOption.Size = new System.Drawing.Size(119, 17);
            this.HideSplashScreenOption.TabIndex = 2;
            this.HideSplashScreenOption.TabStop = true;
            this.HideSplashScreenOption.Text = "Hide Splash Screen";
            this.HideSplashScreenOption.UseVisualStyleBackColor = true;
            this.HideSplashScreenOption.CheckedChanged += new System.EventHandler(this.HideSplashScreenOption_CheckedChanged);
            // 
            // ShowSplashScreenOption
            // 
            this.ShowSplashScreenOption.AutoSize = true;
            this.ShowSplashScreenOption.Location = new System.Drawing.Point(18, 28);
            this.ShowSplashScreenOption.Name = "ShowSplashScreenOption";
            this.ShowSplashScreenOption.Size = new System.Drawing.Size(124, 17);
            this.ShowSplashScreenOption.TabIndex = 1;
            this.ShowSplashScreenOption.TabStop = true;
            this.ShowSplashScreenOption.Text = "Show Splash Screen";
            this.ShowSplashScreenOption.UseVisualStyleBackColor = true;
            this.ShowSplashScreenOption.CheckedChanged += new System.EventHandler(this.ShowSplashScreenOption_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(798, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "The Splash Screen is the screen with the logos and software name, which appears a" +
    "t Startup. You can disable this. Changes will come into effect since the next st" +
    "artup.";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(766, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save All Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unless you save all settings, they will not be in effect.";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Label1);
            this.groupBox4.Controls.Add(this.docksWorkModedisabled);
            this.groupBox4.Controls.Add(this.docsWorkModeenabled);
            this.groupBox4.Location = new System.Drawing.Point(6, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(893, 75);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Google Docks Work Mode";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // docsWorkModeenabled
            // 
            this.docsWorkModeenabled.AutoSize = true;
            this.docsWorkModeenabled.Location = new System.Drawing.Point(19, 33);
            this.docsWorkModeenabled.Name = "docsWorkModeenabled";
            this.docsWorkModeenabled.Size = new System.Drawing.Size(64, 17);
            this.docsWorkModeenabled.TabIndex = 0;
            this.docsWorkModeenabled.TabStop = true;
            this.docsWorkModeenabled.Text = "Enabled";
            this.docsWorkModeenabled.UseVisualStyleBackColor = true;
            this.docsWorkModeenabled.CheckedChanged += new System.EventHandler(this.docsWorkModeenabled_CheckedChanged);
            // 
            // docksWorkModedisabled
            // 
            this.docksWorkModedisabled.AutoSize = true;
            this.docksWorkModedisabled.Location = new System.Drawing.Point(100, 33);
            this.docksWorkModedisabled.Name = "docksWorkModedisabled";
            this.docksWorkModedisabled.Size = new System.Drawing.Size(66, 17);
            this.docksWorkModedisabled.TabIndex = 1;
            this.docksWorkModedisabled.TabStop = true;
            this.docksWorkModedisabled.Text = "Disabled";
            this.docksWorkModedisabled.UseVisualStyleBackColor = true;
            this.docksWorkModedisabled.CheckedChanged += new System.EventHandler(this.docksWorkModedisabled_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(213, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(548, 26);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "This feature helps you work on Google Docs distraction free, by opening a new win" +
    "dow optimized for Google Docs,\r\n with no room for distraction.";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 458);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings | FlameSky";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SettingsHomepage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SettingsScholar;
        private System.Windows.Forms.RadioButton SettingsYouTube;
        private System.Windows.Forms.RadioButton SettingsBing;
        private System.Windows.Forms.RadioButton SettingsGoogle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton HideSplashScreenOption;
        private System.Windows.Forms.RadioButton ShowSplashScreenOption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RadioButton docksWorkModedisabled;
        private System.Windows.Forms.RadioButton docsWorkModeenabled;
    }
}