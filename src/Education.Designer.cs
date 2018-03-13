namespace FlameSky
{
    partial class Education
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.JSTOR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.GoogleScholar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.EncyclopediaBritanica = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.EducationTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.EducationTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(258, 3);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(123, 105);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "Qatar National Library";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // JSTOR
            // 
            this.JSTOR.Depth = 0;
            this.JSTOR.Location = new System.Drawing.Point(129, 114);
            this.JSTOR.MouseState = MaterialSkin.MouseState.HOVER;
            this.JSTOR.Name = "JSTOR";
            this.JSTOR.Primary = true;
            this.JSTOR.Size = new System.Drawing.Size(123, 105);
            this.JSTOR.TabIndex = 4;
            this.JSTOR.Text = "JSTOR";
            this.JSTOR.UseVisualStyleBackColor = true;
            // 
            // GoogleScholar
            // 
            this.GoogleScholar.Depth = 0;
            this.GoogleScholar.Location = new System.Drawing.Point(0, 114);
            this.GoogleScholar.MouseState = MaterialSkin.MouseState.HOVER;
            this.GoogleScholar.Name = "GoogleScholar";
            this.GoogleScholar.Primary = true;
            this.GoogleScholar.Size = new System.Drawing.Size(123, 105);
            this.GoogleScholar.TabIndex = 3;
            this.GoogleScholar.Text = "Google Scholar";
            this.GoogleScholar.UseVisualStyleBackColor = true;
            // 
            // EncyclopediaBritanica
            // 
            this.EncyclopediaBritanica.Depth = 0;
            this.EncyclopediaBritanica.Location = new System.Drawing.Point(0, 3);
            this.EncyclopediaBritanica.MouseState = MaterialSkin.MouseState.HOVER;
            this.EncyclopediaBritanica.Name = "EncyclopediaBritanica";
            this.EncyclopediaBritanica.Primary = true;
            this.EncyclopediaBritanica.Size = new System.Drawing.Size(123, 105);
            this.EncyclopediaBritanica.TabIndex = 6;
            this.EncyclopediaBritanica.Text = "Encyclopedia Britanica";
            this.EncyclopediaBritanica.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(129, 3);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(123, 105);
            this.materialRaisedButton2.TabIndex = 7;
            this.materialRaisedButton2.Text = "Google Scholar";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // EducationTab
            // 
            this.EducationTab.Controls.Add(this.metroTabPage1);
            this.EducationTab.Location = new System.Drawing.Point(23, 63);
            this.EducationTab.Name = "EducationTab";
            this.EducationTab.SelectedIndex = 0;
            this.EducationTab.Size = new System.Drawing.Size(824, 272);
            this.EducationTab.TabIndex = 8;
            this.EducationTab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.materialRaisedButton1);
            this.metroTabPage1.Controls.Add(this.materialRaisedButton2);
            this.metroTabPage1.Controls.Add(this.JSTOR);
            this.metroTabPage1.Controls.Add(this.GoogleScholar);
            this.metroTabPage1.Controls.Add(this.EncyclopediaBritanica);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(816, 230);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Search Engines";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Education
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 358);
            this.Controls.Add(this.EducationTab);
            this.Name = "Education";
            this.Text = "Educational Tools";
            this.Load += new System.EventHandler(this.Education_Load);
            this.EducationTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton JSTOR;
        private MaterialSkin.Controls.MaterialRaisedButton GoogleScholar;
        private MaterialSkin.Controls.MaterialRaisedButton EncyclopediaBritanica;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MetroFramework.Controls.MetroTabControl EducationTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
    }
}