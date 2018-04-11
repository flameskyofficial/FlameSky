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
    public partial class FlameSky_Contacts : MetroFramework.Forms.MetroForm
    {
        public FlameSky_Contacts()
        {
            InitializeComponent();
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_contact_managerDataSet);

        }

        private void FlameSky_Contacts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personal_contact_managerDataSet.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.personal_contact_managerDataSet.Contacts);

        }
    }
}
