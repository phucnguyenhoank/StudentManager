using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.IO;

namespace StudentManager.ContactForms
{
    public partial class FrmEditContact : Form
    {
        public FrmEditContact()
        {
            InitializeComponent();
        }

        private void LoadDepartmentToComboBox()
        {
            DepartmentDAL departmentDAL = new DepartmentDAL();
            try
            {
                List<Department> allDepartments = departmentDAL.GetAllDepartmentsAsList();
                cbDepartmentName.DataSource = allDepartments;
                cbDepartmentName.DisplayMember = "DepartmentName";
                cbDepartmentName.ValueMember = "DepartmentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadDepartmentToComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyContactToForm(Contact contact)
        {
            txtContactID.Text = contact.ContactID;
            txtFirstName.Text = contact.FirstName;
            txtLastName.Text = contact.LastName;
            LoadDepartmentToComboBox();
            cbDepartmentName.SelectedValue = contact.DepartmentID;
            txtPhoneNumber.Text = contact.PhoneNumber;
            txtEmail.Text = contact.Email;
            txtAddress.Text = contact.Address;
            MemoryStream ms = new MemoryStream(contact.Picture);
            picboxContact.Image = Image.FromStream(ms);
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
                    ApplyContactToForm(selectedContact);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtContactID_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);
        }

        private void CheckEmpty(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                erprvEditContact.SetError(textBox, "This field is required.");
            }
            else
            {
                erprvEditContact.SetError(textBox, string.Empty); // Clear error if text is not empty
            }
        }

        private bool IsErrorProviderEmpty()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (!string.IsNullOrEmpty(erprvEditContact.GetError(textBox)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void FrmEditContact_Load(object sender, EventArgs e)
        {
            txtContactID_TextChanged(txtContactID, e);
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsErrorProviderEmpty())
                {
                    MessageBox.Show("Your input is not valid");
                }
                else if (picboxContact.Image == null)
                {
                    MessageBox.Show("Please upload an image");
                }
                else
                {
                    // safe region
                    string contactID = txtContactID.Text.Trim();
                    string firstName = txtFirstName.Text.Trim();
                    string lastName = txtLastName.Text.Trim();

                    Department selectedDepartment = cbDepartmentName.SelectedItem as Department;
                    int departmentID = selectedDepartment.DepartmentID;

                    string phoneNumber = txtPhoneNumber.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string address = txtAddress.Text.Trim();

                    MemoryStream memStream = new MemoryStream();
                    picboxContact.Image.Save(memStream, picboxContact.Image.RawFormat);
                    byte[] contactPicture = memStream.ToArray();

                    Contact contact = new Contact(contactID, firstName, lastName, departmentID, phoneNumber, email, address, contactPicture);

                    ContactDAL contactDAL = new ContactDAL();
                    contactDAL.EditContact(contact);
                    MessageBox.Show("Edit Student Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnEditContact_Click:{ex.Message}");
            }
        }
    }
}
