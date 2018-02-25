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
    public partial class BrowserHistory : MetroFramework.Forms.MetroForm
    {
        public BrowserHistory()
        {
            InitializeComponent();
        }


        private void BrowserHistory_Load(object sender, EventArgs e)
        {
            try
           {
               using (StreamReader r = new StreamReader(@"C:\ProgramData\FlameSky\BrowserHistory.txt"))
                {
                   string line;
                   while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                        

                    }
                    r.Close();
              }
            }
           catch (Exception)
           {
                
                MessageBox.Show("The History section of the browser is occupied in another process, please wait and try again");
                this.Close();
           }

        }

        private void button1_Click(object sender, EventArgs e)

        {
            File.WriteAllText(@"C:\ProgramData\FlameSky\BrowserHistory.txt", String.Empty);


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

          



    }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
         

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\ProgramData\FlameSky\BrowserHistory.txt", FileMode.Truncate, FileAccess.Write)
                {

                };

                Properties.Settings.Default.URLHistory.Clear();
                Properties.Settings.Default.Save();
                
               


            }
            catch (Exception)
            {

            }



            this.Close();

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
    
