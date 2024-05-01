using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager.ContactForms
{
    public partial class FrmContactManager : Form
    {
        public FrmContactManager()
        {
            InitializeComponent();
        }

        private void btnSelectContact_Click(object sender, EventArgs e)
        {
            try
            {
                FrmContactSelector frmContactSelector = new FrmContactSelector();
                frmContactSelector.ShowDialog();
                Contact selectedContact = frmContactSelector.SelectedContact;
                if (selectedContact != null)
                {
                    txtRemovedContactID.Text = selectedContact.ContactID;
                }
                else
                {
                    MessageBox.Show($"Not have data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnSelectContact_Click:{ex.Message}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the contact ID to be removed
                string contactIDToRemove = txtRemovedContactID.Text;
                if (string.IsNullOrEmpty(contactIDToRemove))
                {
                    MessageBox.Show("Please select the contact you want to remove.");
                    return;
                }

                // Display a confirmation dialog before proceeding with deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ContactDAL contactDAL = new ContactDAL();
                    contactDAL.RemoveContact(contactIDToRemove);

                    MessageBox.Show("Contact successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtRemovedContactID.Text = "";
                }
                else
                {
                    MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show($"btnRemove_Click:{ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddContact frmAddContact = new FrmAddContact();
            frmAddContact.ShowDialog(this);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditContact frmEditContact = new FrmEditContact();
            frmEditContact.ShowDialog(this);
        }

        private void btnShowFullList_Click(object sender, EventArgs e)
        {
            FrmShowFullList frmShowFullList = new FrmShowFullList();
            frmShowFullList.ShowDialog(this);
        }
    }
}
