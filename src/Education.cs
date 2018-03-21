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
    public partial class Education : MetroFramework.Forms.MetroForm
    {

        public Education()
        {
            InitializeComponent();
        }

        private void Education_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flameSkyPlannerDataSet.Timetable' table. You can move, or remove it, as needed.
            this.timetableTableAdapter.Fill(this.flameSkyPlannerDataSet.Timetable);
            // TODO: This line of code loads data into the 'flameSkyPlannerDataSet.Timetable' table. You can move, or remove it, as needed.
            this.timetableTableAdapter.Fill(this.flameSkyPlannerDataSet.Timetable);
            timetableBindingSource.DataSource = this.flameSkyPlannerDataSet.Timetable;


        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Error updating. Try again");
                timetableBindingSource.ResetBindings(false);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            Titleoftaskinput.Focus();
            this.flameSkyPlannerDataSet.Timetable.AddTimetableRow(this.flameSkyPlannerDataSet.Timetable.NewTimetableRow());
            timetableBindingSource.MoveLast();
        }
    }
}
