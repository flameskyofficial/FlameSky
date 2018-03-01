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
        DataTable table;
        public FlameSkyNotes()
        {
            InitializeComponent();
        }

        private void FlameSkyNotes_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Body", typeof(String));
            SavedNotesView.DataSource = table;
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
                NoteTitle.Text = table.Rows[index].ItemArray[0].ToString();
                NotesBody.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            NoteTitle.Clear();
            NotesBody.Clear();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(NoteTitle.Text, NotesBody.Text);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = SavedNotesView.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            catch (Exception)
            {

            }
            
        }
    }
}
