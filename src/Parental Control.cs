using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameSky
{
    public partial class Parental_Control : MetroFramework.Forms.MetroForm
    {
        public Parental_Control()
        {
            InitializeComponent();
        }

        private void Parental_Control_Load(object sender, EventArgs e)
        {
            ParentalAuthorityUsernameTextBox.Text = Properties.Settings.Default.ParentalAuthorityUsername;
            ParentalAuthorityPasswordTextBox.Text = Properties.Settings.Default.ParentalAuthorityPassword;
            
            if (Properties.Settings.Default.ParentalAuthorityLockEnabled)
            {
                EnableParentalAuthorityCheckbox.Checked = true;
            }
            else
            {
                EnableParentalAuthorityCheckbox.Checked = false;
            }
            if (Properties.Settings.Default.TimeLimitEnabled)
            {
                metroCheckBox1.Checked = true;
            }
            else
            {
               metroCheckBox1.Checked = false;
            }
            if (Properties.Settings.Default.Time == 1800000)
            {
                Min30.Checked = true;
            }
            else
            {
                Min30.Checked = false;
            }
            if (Properties.Settings.Default.Time == 3600000)
            {
                Hour1.Checked = true;
            }
            else
            {
                Hour1.Checked = false;
            }
            if (Properties.Settings.Default.Time == 5400000)
            {
                Hour1Min30.Checked = true;
            }
            else
            {
                Hour1Min30.Checked = false;
            }
            if (Properties.Settings.Default.Time == 3600000)
            {
                Hour2.Checked = true;
            }
            else
            {
                Hour2.Checked = false;
            }
        }

        private void EditUsername_Click(object sender, EventArgs e)
        {
            ParentalAuthorityUsernameTextBox.Enabled = true;
        }

        private void EditPassword_Click(object sender, EventArgs e)
        {
            ParentalAuthorityPasswordTextBox.Enabled = true;
        }

        private void EnableParentalAuthorityCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableParentalAuthorityCheckbox.Checked)
            {
                Properties.Settings.Default.ParentalAuthorityLockEnabled = true;
            }
            else
            {
                Properties.Settings.Default.ParentalAuthorityLockEnabled = false;
            }
            
        }

        private void ParentalAuthorityPasswordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void ParentalAuthorityUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParentalAuthorityUsername = ParentalAuthorityUsernameTextBox.Text;
        }

        private void ParentalAuthorityPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParentalAuthorityPassword = ParentalAuthorityPasswordTextBox.Text;
        }

        
        private void timelimit_Click(object sender, EventArgs e)
        {
          
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                Properties.Settings.Default.TimeLimitEnabled = true;
            }
            else
            {
                Properties.Settings.Default.TimeLimitEnabled = false;
            }
        }

       
        private void Min30_CheckedChanged(object sender, EventArgs e)
        {
            if (Min30.Checked)
            {
                Properties.Settings.Default.Time = 1800000;
            }
        }

        private void Hour1_CheckedChanged(object sender, EventArgs e)
        {
            if (Hour1.Checked)
            {
                Properties.Settings.Default.Time = 3600000;
            }
        }

        private void Hour1Min30_CheckedChanged(object sender, EventArgs e)
        {
            if (Hour1Min30.Checked)
            {
                Properties.Settings.Default.Time = 5400000;
            }
        }

        private void Hour2_CheckedChanged(object sender, EventArgs e)
        {
            if (Hour2.Checked)
            {
                Properties.Settings.Default.Time = 7200000;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@FlameSky.Properties.Settings.Default.BrowserHistoryFilepath, FileMode.Truncate, FileAccess.Write)
                {

                };

                Properties.Settings.Default.URLHistory.Clear();
                Properties.Settings.Default.Save();




            }
            catch (Exception)
            {

            }

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ParentalControlsSignUpFirstTime = true;
            Properties.Settings.Default.ParentalAuthorityLockEnabled = false;
            Properties.Settings.Default.ParentalAuthorityUsername = "";
            Properties.Settings.Default.TimeLimitEnabled = false;
            Properties.Settings.Default.ParentalAuthorityPassword = "";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restart your browser to see all changes in effect.");
        }
    }
}
