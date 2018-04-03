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
    
    public partial class SettingsParentalAuthority : MetroFramework.Forms.MetroForm
    {
        public SettingsParentalAuthority()
        {
            InitializeComponent();
        }

        private void SettingsParentalAuthority_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text==Properties.Settings.Default.ParentalAuthorityUsername && metroTextBox2.Text == Properties.Settings.Default.ParentalAuthorityPassword)
            {
                new Settings().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your Username and/or Password is incorrect. If you forget any one of the either, you must reinstall this browser.");
            }
        }

        private void SettingsParentalAuthority_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (metroTextBox1.Text == Properties.Settings.Default.ParentalAuthorityUsername && metroTextBox2.Text == Properties.Settings.Default.ParentalAuthorityPassword)
                {
                    new Settings().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your Username and/or Password is incorrect. If you forget any one of the either, you must reinstall this browser.");
                }
            }
        }
    }
}
