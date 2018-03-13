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
            this.components = new System.ComponentModel.Container();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FlameSky.Properties.Resources.FlameSkyLogo;
            this.pictureBox2.Location = new System.Drawing.Point(868, 24);
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
            this.tabControl1.Location = new System.Drawing.Point(1, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 351);
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
            this.tabPage1.Size = new System.Drawing.Size(906, 325);
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unless you save all settings, they will not be in effect.";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
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
           
            this.Text = "Settings ";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SettingsHomepage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SettingsScholar;
        private System.Windows.Forms.RadioButton SettingsYouTube;
        private System.Windows.Forms.RadioButton SettingsBing;
        private System.Windows.Forms.RadioButton SettingsGoogle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}