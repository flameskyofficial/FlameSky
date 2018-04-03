using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameSky.Properties
{
    public partial class TimeLimitForm : MetroFramework.Forms.MetroForm
    {
        MainForm myForm;
        public TimeLimitForm()
        {
            InitializeComponent();
        }

        private void TimeLimit_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == Properties.Settings.Default.ParentalAuthorityUsername && metroTextBox2.Text == Properties.Settings.Default.ParentalAuthorityPassword)
            {
             
                myForm.Show();
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Your Username and/or Password is incorrect. If you forget any one of the either, you must reinstall this browser.");
            }
        }
    }
}
