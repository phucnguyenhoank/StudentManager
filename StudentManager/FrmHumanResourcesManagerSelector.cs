using StudentManager.ContactForms;
using StudentManager.DepartmentForms;
using StudentManager.TeachForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FrmHumanResourcesManagerSelector : Form
    {
        public FrmHumanResourcesManagerSelector()
        {
            InitializeComponent();
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddContact frmAddContact = new FrmAddContact();
            frmAddContact.ShowDialog(this);
        }

        private void contactManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContactManager frmContactManager = new FrmContactManager();
            frmContactManager.ShowDialog(this);
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageDepartment frmManageDepartment = new FrmManageDepartment();
            frmManageDepartment.ShowDialog(this);
        }

        private void addTeachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddTeach frmAddTeach = new FrmAddTeach();
            frmAddTeach.ShowDialog(this);
        }
    }
}
