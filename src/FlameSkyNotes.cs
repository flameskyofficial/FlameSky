using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FlameSky
{
    public partial class FlameSkyNotes : MaterialSkin.Controls.MaterialForm
    {
        public FlameSkyNotes()
        {
            InitializeComponent();
        }

        private void FlameSkyNotes_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text; //Dynamically updates title as user changes title
        }
    }
}
