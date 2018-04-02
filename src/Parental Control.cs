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
            
            if (Properties.Settings.Default.ParentalAuthorityLockEnabled == true)
            {
                EnableParentalAuthorityCheckbox.Checked = true;
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
            Properties.Settings.Default.ParentalAuthorityLockEnabled = true;
        }
    }
}
