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
    public partial class FlameSkyNotes : MetroFramework.Forms.MetroForm
    {
        
        public FlameSkyNotes()
        {
            InitializeComponent();
        }

        private void FlameSkyNotes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flameSkyDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.flameSkyDataSet.Table);
            
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            int index = SavedNotesView.CurrentCell.RowIndex;
            if (index > -1)
            {
                
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            NoteTitle.Clear();
            NotesBody.Clear();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           tableTableAdapter.Insert(NoteTitle.Text, NotesBody.Text);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = SavedNotesView.CurrentCell.RowIndex;
                
            }
            catch (Exception)
            {

            }
            
        }
    }
}
