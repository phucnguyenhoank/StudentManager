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
    public partial class FrmContactSelector : Form
    {
        private Contact selectedContact = null;
        public Contact SelectedContact
        {
            get { return selectedContact; }
        }

        public FrmContactSelector()
        {
            InitializeComponent();
        }

        private void LoadDataIntoContactGridView()
        {
            ContactDAL contact = new ContactDAL();
            dtgvContact.DataSource = contact.GetContactsAsDataTable();
            dtgvContact.Columns["contactID"].HeaderText = "Contact ID";
            dtgvContact.Columns["firstName"].HeaderText = "Tên";
            dtgvContact.Columns["lastName"].HeaderText = "Họ";
            dtgvContact.Columns["departmentID"].HeaderText = "Department ID";
            dtgvContact.Columns["phoneNumber"].HeaderText = "SĐT";
            dtgvContact.Columns["email"].HeaderText = "Email";
            dtgvContact.Columns["address"].HeaderText = "Địa chỉ";
            dtgvContact.Columns["picture"].HeaderText = "Ảnh";
            ((DataGridViewImageColumn)dtgvContact.Columns["picture"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void FrmContactSelector_Load(object sender, EventArgs e)
        {
            LoadDataIntoContactGridView();
        }

        private void dtgvContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is double-clicked
            {
                DataGridView dataGridView = sender as DataGridView;
                if (dataGridView != null)
                {
                    // Get the DataGridViewRow corresponding to the clicked row
                    DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];

                    // Access data from each cell in the clicked row
                    string contactID = clickedRow.Cells["contactID"].Value.ToString();
                    string firstName = clickedRow.Cells["firstName"].Value?.ToString();
                    string lastName = clickedRow.Cells["lastName"].Value?.ToString();
                    int departmentID = (int)clickedRow.Cells["departmentID"].Value;
                    string phoneNumber = clickedRow.Cells["phoneNumber"].Value?.ToString();
                    string email = clickedRow.Cells["email"].Value?.ToString();
                    string address = clickedRow.Cells["address"].Value?.ToString();
                    byte[] picture = clickedRow.Cells["picture"].Value as byte[];

                    Contact contact = new Contact(contactID, firstName, lastName, departmentID, phoneNumber, email, address, picture);
                    selectedContact = contact;
                    Close();
                }
            }
        }
    }
}
