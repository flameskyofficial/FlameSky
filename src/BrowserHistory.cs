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
    public partial class BrowserHistory : Form
    {
        public BrowserHistory()
        {
            InitializeComponent();
        }


        private void BrowserHistory_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader(@"C:\ProgramData\FlameSky\FlameSkyHistory.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)

        {
            File.WriteAllText(@"C:\ProgramData\FlameSky\FlameSkyHistory.txt", String.Empty);


        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


            }

            catch (Exception)
            {

            }







            this.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void historyTableBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"C:\ProgramData\FlameSky\FlameSkyHistory.txt", FileMode.Truncate, FileAccess.Write)
            {

            };
            


            this.Close();




    }
    }
}
    
