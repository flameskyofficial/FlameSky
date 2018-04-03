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
    
    public partial class FlashForm : MaterialSkin.Controls.MaterialForm
    {
       
        public FlashForm()
        {
            InitializeComponent();
        }

        private void FlashForm_Load(object sender, EventArgs e)
        {
            this.Focus();
            webBrowser1.Navigate("https://get.adobe.com/flashplayer/otherversions/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            this.Close();
        }
    }
}
