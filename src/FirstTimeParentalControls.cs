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
    public partial class FirstTimeParentalControls : MetroFramework.Forms.MetroForm
    {
        public FirstTimeParentalControls()
        {
            InitializeComponent();
        }

        private void FirstTimeParentalControls_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text!="" & PasswordTextBox.Text != "")
            {
                Properties.Settings.Default.ParentalAuthorityUsername = UsernameTextBox.Text;
                Properties.Settings.Default.ParentalAuthorityPassword = PasswordTextBox.Text;
                Properties.Settings.Default.ParentalControlsSignUpFirstTime = false;
                Properties.Settings.Default.Save();
                new Parental_Control().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password cannot be blank.");
            }

        }
    }
}
