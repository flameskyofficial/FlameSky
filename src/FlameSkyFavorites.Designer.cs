namespace FlameSky
{
    partial class FlameSkyFavorites
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
            System.Windows.Forms.Label webpage_NameLabel;
            System.Windows.Forms.Label webpage_URLLabel;
            System.Windows.Forms.Label notesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlameSkyFavorites));
            this.flameSkyFavoritesDataSet = new FlameSky.FlameSkyFavoritesDataSet();
            this.favoritesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favoritesTableAdapter = new FlameSky.FlameSkyFavoritesDataSetTableAdapters.FavoritesTableAdapter();
            this.tableAdapterManager = new FlameSky.FlameSkyFavoritesDataSetTableAdapters.TableAdapterManager();
            this.favoritesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.favoritesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.favoritesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webpage_NameTextBox = new System.Windows.Forms.TextBox();
            this.webpage_URLTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            webpage_NameLabel = new System.Windows.Forms.Label();
            webpage_URLLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flameSkyFavoritesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingNavigator)).BeginInit();
            this.favoritesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // webpage_NameLabel
            // 
            webpage_NameLabel.AutoSize = true;
            webpage_NameLabel.Location = new System.Drawing.Point(23, 111);
            webpage_NameLabel.Name = "webpage_NameLabel";
            webpage_NameLabel.Size = new System.Drawing.Size(88, 13);
            webpage_NameLabel.TabIndex = 2;
            webpage_NameLabel.Text = "Webpage Name:";
            // 
            // webpage_URLLabel
            // 
            webpage_URLLabel.AutoSize = true;
            webpage_URLLabel.Location = new System.Drawing.Point(29, 164);
            webpage_URLLabel.Name = "webpage_URLLabel";
            webpage_URLLabel.Size = new System.Drawing.Size(82, 13);
            webpage_URLLabel.TabIndex = 4;
            webpage_URLLabel.Text = "Webpage URL:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(73, 214);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 6;
            notesLabel.Text = "Notes:";
            // 
            // flameSkyFavoritesDataSet
            // 
            this.flameSkyFavoritesDataSet.DataSetName = "FlameSkyFavoritesDataSet";
            this.flameSkyFavoritesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // favoritesBindingSource
            // 
            this.favoritesBindingSource.DataMember = "Favorites";
            this.favoritesBindingSource.DataSource = this.flameSkyFavoritesDataSet;
            // 
            // favoritesTableAdapter
            // 
            this.favoritesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FavoritesTableAdapter = this.favoritesTableAdapter;
            this.tableAdapterManager.UpdateOrder = FlameSky.FlameSkyFavoritesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // favoritesBindingNavigator
            // 
            this.favoritesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.favoritesBindingNavigator.BindingSource = this.favoritesBindingSource;
            this.favoritesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.favoritesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.favoritesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.favoritesBindingNavigatorSaveItem});
            this.favoritesBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.favoritesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.favoritesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.favoritesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.favoritesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.favoritesBindingNavigator.Name = "favoritesBindingNavigator";
            this.favoritesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.favoritesBindingNavigator.Size = new System.Drawing.Size(740, 25);
            this.favoritesBindingNavigator.TabIndex = 0;
            this.favoritesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // favoritesBindingNavigatorSaveItem
            // 
            this.favoritesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favoritesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("favoritesBindingNavigatorSaveItem.Image")));
            this.favoritesBindingNavigatorSaveItem.Name = "favoritesBindingNavigatorSaveItem";
            this.favoritesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.favoritesBindingNavigatorSaveItem.Text = "Save Data";
            this.favoritesBindingNavigatorSaveItem.Click += new System.EventHandler(this.favoritesBindingNavigatorSaveItem_Click);
            // 
            // favoritesDataGridView
            // 
            this.favoritesDataGridView.AutoGenerateColumns = false;
            this.favoritesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.favoritesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.favoritesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.favoritesDataGridView.DataSource = this.favoritesBindingSource;
            this.favoritesDataGridView.Location = new System.Drawing.Point(302, 88);
            this.favoritesDataGridView.Name = "favoritesDataGridView";
            this.favoritesDataGridView.Size = new System.Drawing.Size(458, 289);
            this.favoritesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Webpage Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Webpage Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Webpage URL";
            this.dataGridViewTextBoxColumn3.HeaderText = "Webpage URL";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn4.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // webpage_NameTextBox
            // 
            this.webpage_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.favoritesBindingSource, "Webpage Name", true));
            this.webpage_NameTextBox.Location = new System.Drawing.Point(117, 108);
            this.webpage_NameTextBox.Name = "webpage_NameTextBox";
            this.webpage_NameTextBox.Size = new System.Drawing.Size(179, 20);
            this.webpage_NameTextBox.TabIndex = 3;
            // 
            // webpage_URLTextBox
            // 
            this.webpage_URLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.favoritesBindingSource, "Webpage URL", true));
            this.webpage_URLTextBox.Location = new System.Drawing.Point(117, 161);
            this.webpage_URLTextBox.Name = "webpage_URLTextBox";
            this.webpage_URLTextBox.Size = new System.Drawing.Size(179, 20);
            this.webpage_URLTextBox.TabIndex = 5;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.favoritesBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(117, 211);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notesTextBox.Size = new System.Drawing.Size(179, 121);
            this.notesTextBox.TabIndex = 7;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(204, 354);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(82, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Navigate";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FlameSkyFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 393);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(webpage_URLLabel);
            this.Controls.Add(this.webpage_URLTextBox);
            this.Controls.Add(webpage_NameLabel);
            this.Controls.Add(this.webpage_NameTextBox);
            this.Controls.Add(this.favoritesDataGridView);
            this.Controls.Add(this.favoritesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlameSkyFavorites";
            this.Resizable = false;
            this.Text = "FlameSky Favorites";
            this.Load += new System.EventHandler(this.FlameSkyFavorites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flameSkyFavoritesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesBindingNavigator)).EndInit();
            this.favoritesBindingNavigator.ResumeLayout(false);
            this.favoritesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoritesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlameSkyFavoritesDataSet flameSkyFavoritesDataSet;
        private System.Windows.Forms.BindingSource favoritesBindingSource;
        private FlameSkyFavoritesDataSetTableAdapters.FavoritesTableAdapter favoritesTableAdapter;
        private FlameSkyFavoritesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator favoritesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton favoritesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView favoritesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox webpage_NameTextBox;
        private System.Windows.Forms.TextBox webpage_URLTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}