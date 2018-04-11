namespace FlameSky
{
    partial class FlameSkyPlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlameSkyPlanner));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label taskLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label due_DateLabel;
            System.Windows.Forms.Label additional_notesLabel;
            this.flameSkyPlannerDataSet = new FlameSky.FlameSkyPlannerDataSet();
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableTableAdapter = new FlameSky.FlameSkyPlannerDataSetTableAdapters.TimetableTableAdapter();
            this.tableAdapterManager = new FlameSky.FlameSkyPlannerDataSetTableAdapters.TableAdapterManager();
            this.timetableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.timetableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timetableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.due_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.additional_notesTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            taskLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            due_DateLabel = new System.Windows.Forms.Label();
            additional_notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flameSkyPlannerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingNavigator)).BeginInit();
            this.timetableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // flameSkyPlannerDataSet
            // 
            this.flameSkyPlannerDataSet.DataSetName = "FlameSkyPlannerDataSet";
            this.flameSkyPlannerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataMember = "Timetable";
            this.timetableBindingSource.DataSource = this.flameSkyPlannerDataSet;
            // 
            // timetableTableAdapter
            // 
            this.timetableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TimetableTableAdapter = this.timetableTableAdapter;
            this.tableAdapterManager.UpdateOrder = FlameSky.FlameSkyPlannerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timetableBindingNavigator
            // 
            this.timetableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.timetableBindingNavigator.BindingSource = this.timetableBindingSource;
            this.timetableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.timetableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.timetableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.timetableBindingNavigatorSaveItem});
            this.timetableBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.timetableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.timetableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.timetableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.timetableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.timetableBindingNavigator.Name = "timetableBindingNavigator";
            this.timetableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.timetableBindingNavigator.Size = new System.Drawing.Size(1108, 25);
            this.timetableBindingNavigator.TabIndex = 0;
            this.timetableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // timetableBindingNavigatorSaveItem
            // 
            this.timetableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.timetableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("timetableBindingNavigatorSaveItem.Image")));
            this.timetableBindingNavigatorSaveItem.Name = "timetableBindingNavigatorSaveItem";
            this.timetableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.timetableBindingNavigatorSaveItem.Text = "Save Data";
            this.timetableBindingNavigatorSaveItem.Click += new System.EventHandler(this.timetableBindingNavigatorSaveItem_Click_1);
            // 
            // timetableDataGridView
            // 
            this.timetableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timetableDataGridView.AutoGenerateColumns = false;
            this.timetableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetableDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.timetableDataGridView.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.timetableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timetableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.timetableDataGridView.DataSource = this.timetableBindingSource;
            this.timetableDataGridView.Location = new System.Drawing.Point(319, 88);
            this.timetableDataGridView.Name = "timetableDataGridView";
            this.timetableDataGridView.Size = new System.Drawing.Size(806, 391);
            this.timetableDataGridView.TabIndex = 1;
            this.timetableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timetableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Task";
            this.dataGridViewTextBoxColumn2.HeaderText = "Task";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Due Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Additional notes";
            this.dataGridViewTextBoxColumn5.HeaderText = "Additional notes";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(53, 97);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(80, 97);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(233, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // taskLabel
            // 
            taskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            taskLabel.AutoSize = true;
            taskLabel.Location = new System.Drawing.Point(40, 130);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new System.Drawing.Size(34, 13);
            taskLabel.TabIndex = 4;
            taskLabel.Text = "Task:";
            // 
            // taskTextBox
            // 
            this.taskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.taskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetableBindingSource, "Task", true));
            this.taskTextBox.Location = new System.Drawing.Point(80, 127);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(233, 20);
            this.taskTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(11, 156);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetableBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(80, 153);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(233, 109);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // due_DateLabel
            // 
            due_DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            due_DateLabel.AutoSize = true;
            due_DateLabel.Location = new System.Drawing.Point(18, 291);
            due_DateLabel.Name = "due_DateLabel";
            due_DateLabel.Size = new System.Drawing.Size(56, 13);
            due_DateLabel.TabIndex = 8;
            due_DateLabel.Text = "Due Date:";
            // 
            // due_DateDateTimePicker
            // 
            this.due_DateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.due_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.timetableBindingSource, "Due Date", true));
            this.due_DateDateTimePicker.Location = new System.Drawing.Point(80, 287);
            this.due_DateDateTimePicker.Name = "due_DateDateTimePicker";
            this.due_DateDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.due_DateDateTimePicker.TabIndex = 9;
            // 
            // additional_notesLabel
            // 
            additional_notesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            additional_notesLabel.AutoSize = true;
            additional_notesLabel.Location = new System.Drawing.Point(18, 322);
            additional_notesLabel.Name = "additional_notesLabel";
            additional_notesLabel.Size = new System.Drawing.Size(56, 26);
            additional_notesLabel.TabIndex = 10;
            additional_notesLabel.Text = "Additional \r\nnotes:";
            // 
            // additional_notesTextBox
            // 
            this.additional_notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.additional_notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.timetableBindingSource, "Additional notes", true));
            this.additional_notesTextBox.Location = new System.Drawing.Point(80, 322);
            this.additional_notesTextBox.Multiline = true;
            this.additional_notesTextBox.Name = "additional_notesTextBox";
            this.additional_notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.additional_notesTextBox.Size = new System.Drawing.Size(233, 157);
            this.additional_notesTextBox.TabIndex = 11;
            // 
            // FlameSkyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 509);
            this.Controls.Add(additional_notesLabel);
            this.Controls.Add(this.additional_notesTextBox);
            this.Controls.Add(due_DateLabel);
            this.Controls.Add(this.due_DateDateTimePicker);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(taskLabel);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.timetableDataGridView);
            this.Controls.Add(this.timetableBindingNavigator);
            this.Name = "FlameSkyPlanner";
            this.Text = "FlameSky Planner";
            this.Load += new System.EventHandler(this.FlameSkyPlanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flameSkyPlannerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingNavigator)).EndInit();
            this.timetableBindingNavigator.ResumeLayout(false);
            this.timetableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlameSkyPlannerDataSet flameSkyPlannerDataSet;
        private System.Windows.Forms.BindingSource timetableBindingSource;
        private FlameSkyPlannerDataSetTableAdapters.TimetableTableAdapter timetableTableAdapter;
        private FlameSkyPlannerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator timetableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton timetableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView timetableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker due_DateDateTimePicker;
        private System.Windows.Forms.TextBox additional_notesTextBox;
    }
}