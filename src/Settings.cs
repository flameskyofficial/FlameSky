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
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SettingsHomepage.Text = FlameSky.Properties.Settings.Default.Homepage;
            if (FlameSky.Properties.Settings.Default.DefaultSearchEngine == "https://www.google.com/search?q=")
            {
                SettingsGoogle.Checked = true;
            }
            else if(FlameSky.Properties.Settings.Default.DefaultSearchEngine == "https://www.bing.com/search?q=")
            {
                SettingsBing.Checked = true;
            }
            else if(FlameSky.Properties.Settings.Default.DefaultSearchEngine == "https://www.youtube.com/results?search_query=")
            {
                SettingsYouTube.Checked = true;
            }
            else if(FlameSky.Properties.Settings.Default.DefaultSearchEngine == "https://scholar.google.com/scholar?hl=en&as_sdt=0%2C5&q=")
            {
                SettingsScholar.Checked = true;
            }

            
        }

        private void SettingsHomepage_TextChanged(object sender, EventArgs e)
        {
            FlameSky.Properties.Settings.Default.Homepage = SettingsHomepage.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlameSky.Properties.Settings.Default.Save();
        }

        private void SettingsGoogle_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsGoogle.Checked)
            {
                FlameSky.Properties.Settings.Default.DefaultSearchEngine = "https://www.google.com/search?q=";
               
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SettingsBing_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsBing.Checked)
            {
                FlameSky.Properties.Settings.Default.DefaultSearchEngine = "https://www.bing.com/search?q=";
                
            }
        }

        private void SettingsYoutube_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsYouTube.Checked)
            {
                
                FlameSky.Properties.Settings.Default.DefaultSearchEngine = "https://www.youtube.com/results?search_query=";
                
            }
        }

        private void SettingsScholar_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsScholar.Checked)
            {
                FlameSky.Properties.Settings.Default.DefaultSearchEngine = "https://scholar.google.com/scholar?hl=en&as_sdt=0%2C5&q=";
               
            }
        }

        

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            FlameSky.Properties.Settings.Default.Save();
            MessageBox.Show("Settings Updated");
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Doc_CheckedChanged(object sender, EventArgs e)
        {
       
    }

       
    }
    }
