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
            // TODO: This line of code loads data into the 'flameSkyPlannerDataSet.Tasktable' table. You can move, or remove it, as needed.
            this.tasktableTableAdapter.Fill(this.flameSkyPlannerDataSet.Tasktable);
            // TODO: This line of code loads data into the 'flameSkyPlannerDataSet.Timetable' table. You can move, or remove it, as needed.


        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
