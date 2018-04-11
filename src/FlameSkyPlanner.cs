using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameSky
{
    public partial class FlameSkyPlanner : MetroFramework.Forms.MetroForm
    {
        public FlameSkyPlanner()
        {
            InitializeComponent();
        }

        private void FlameSkyPlanner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flameSkyPlannerDataSet.Timetable' table. You can move, or remove it, as needed.
            this.timetableTableAdapter.Fill(this.flameSkyPlannerDataSet.Timetable);
            // TODO: This line of code loads data into the 'flameSkyPlannerDataSet.Timetable' table. You can move, or remove it, as needed.
            this.timetableTableAdapter.Fill(this.flameSkyPlannerDataSet.Timetable);

        }

        private void timetableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.timetableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flameSkyPlannerDataSet);

        }

        private void timetableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.timetableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flameSkyPlannerDataSet);

        }

        private void timetableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
