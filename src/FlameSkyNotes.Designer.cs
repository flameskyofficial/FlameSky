namespace FlameSky
{
    partial class FlameSkyNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlameSkyNotes));
            this.TitleLabel = new MetroFramework.Controls.MetroLabel();
            this.NoteTitle = new MetroFramework.Controls.MetroTextBox();
            this.NotesBody = new System.Windows.Forms.RichTextBox();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnRead = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.SavedNotesView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SavedNotesView)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(33, 74);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(33, 19);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // NoteTitle
            // 
            this.NoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.NoteTitle.CustomButton.Image = null;
            this.NoteTitle.CustomButton.Location = new System.Drawing.Point(360, 1);
            this.NoteTitle.CustomButton.Name = "";
            this.NoteTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoteTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoteTitle.CustomButton.TabIndex = 1;
            this.NoteTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoteTitle.CustomButton.UseSelectable = true;
            this.NoteTitle.CustomButton.Visible = false;
            this.NoteTitle.Lines = new string[] {
        "Untitled"};
            this.NoteTitle.Location = new System.Drawing.Point(72, 74);
            this.NoteTitle.MaxLength = 32767;
            this.NoteTitle.Name = "NoteTitle";
            this.NoteTitle.PasswordChar = '\0';
            this.NoteTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoteTitle.SelectedText = "";
            this.NoteTitle.SelectionLength = 0;
            this.NoteTitle.SelectionStart = 0;
            this.NoteTitle.ShortcutsEnabled = true;
            this.NoteTitle.Size = new System.Drawing.Size(382, 23);
            this.NoteTitle.TabIndex = 2;
            this.NoteTitle.Text = "Untitled";
            this.NoteTitle.UseSelectable = true;
            this.NoteTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NoteTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NotesBody
            // 
            this.NotesBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesBody.Location = new System.Drawing.Point(33, 103);
            this.NotesBody.Name = "NotesBody";
            this.NotesBody.Size = new System.Drawing.Size(421, 249);
            this.NotesBody.TabIndex = 3;
            this.NotesBody.Text = "";
            this.NotesBody.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNew.Location = new System.Drawing.Point(33, 368);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(40, 23);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.Text = "New";
            this.BtnNew.UseSelectable = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Location = new System.Drawing.Point(90, 368);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(57, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseSelectable = true;
            // 
            // BtnRead
            // 
            this.BtnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRead.Location = new System.Drawing.Point(162, 368);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(57, 23);
            this.BtnRead.TabIndex = 6;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseSelectable = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(240, 368);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(57, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            // 
            // SavedNotesView
            // 
            this.SavedNotesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavedNotesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SavedNotesView.Location = new System.Drawing.Point(474, 103);
            this.SavedNotesView.Name = "SavedNotesView";
            this.SavedNotesView.Size = new System.Drawing.Size(336, 249);
            this.SavedNotesView.TabIndex = 8;
            // 
            // FlameSkyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 400);
            this.Controls.Add(this.SavedNotesView);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.NotesBody);
            this.Controls.Add(this.NoteTitle);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlameSkyNotes";
            this.Text = "FlameSky Notes";
            this.Load += new System.EventHandler(this.FlameSkyNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SavedNotesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel TitleLabel;
        private MetroFramework.Controls.MetroTextBox NoteTitle;
        private System.Windows.Forms.RichTextBox NotesBody;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnRead;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private System.Windows.Forms.DataGridView SavedNotesView;
    }
}