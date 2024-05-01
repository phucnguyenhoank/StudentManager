using DAL;
using DTO;
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

namespace StudentManager.ContactForms
{
    public partial class FrmAddContact : Form
    {
        public FrmAddContact()
        {
            InitializeComponent();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picboxContact.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                    contactDAL.AddContact(contact);
                    MessageBox.Show("Add Contact successfully");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"[btnAddStudent_Click:{ex.Message}]");
            }
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

        private void FrmAddContact_Load(object sender, EventArgs e)
        {
            LoadDepartmentToComboBox();
            txtContactID_TextChanged(txtContactID, e);
            txtFirstName_TextChanged(txtFirstName, e);
            txtLastName_TextChanged(txtLastName, e);
            txtPhoneNumber_TextChanged(txtPhoneNumber , e);
            txtEmail_TextChanged(txtEmail , e);
            txtAddress_TextChanged(txtAddress , e);
        }
        
        
        private void txtContactID_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);
            // Check contact existence only if the TextBox is not empty
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                string contactID = textBox.Text;

                // Check if a contact with the specified ContactID exists
                ContactDAL contactDAL = new ContactDAL();
                if (contactDAL.HaveContact(contactID))
                {
                    // Set error for the ErrorProvider if contact exists
                    erprvAddContact.SetError(textBox, "ContactID already exists.");
                }
                else
                {
                    // Clear error for the ErrorProvider if contact does not exist
                    erprvAddContact.SetError(textBox, string.Empty);
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);

            // Check if firstName contains any digits using regular expression
            if (!string.IsNullOrWhiteSpace(textBox.Text) && System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"\d"))
            {
                // Set error for the ErrorProvider if firstName contains digits
                erprvAddContact.SetError(textBox, "First name should not contain digits.");
            }
            else
            {
                // Clear error for the ErrorProvider if firstName does not contain digits
                erprvAddContact.SetError(textBox, string.Empty);
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);

            // Check if lastName contains any digits using regular expression
            if (!string.IsNullOrWhiteSpace(textBox.Text) && System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"\d"))
            {
                // Set error for the ErrorProvider if lastName contains digits
                erprvAddContact.SetError(textBox, "Last name should not contain digits.");
            }
            else
            {
                // Clear error for the ErrorProvider if lastName does not contain digits
                erprvAddContact.SetError(textBox, string.Empty);
            }
        }


        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            CheckEmpty(textBox);

            // Check contact existence only if the TextBox is not empty
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                string phoneNumber = textBox.Text;

                // Check if phoneNumber contains any non-digit characters using regular expression
                if (System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"[^\d]"))
                {
                    // Set error for the ErrorProvider if phoneNumber contains non-digit characters
                    erprvAddContact.SetError(textBox, "Phone number should contain only digits.");
                }
                else
                {
                    // Clear error for the ErrorProvider if phoneNumber contains only digits
                    erprvAddContact.SetError(textBox, string.Empty);
                }
            }
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
                erprvAddContact.SetError(textBox, "This field is required.");
            }
            else
            {
                erprvAddContact.SetError(textBox, string.Empty); // Clear error if text is not empty
            }
        }

        private bool IsErrorProviderEmpty()
        {
            // Check if there is any error set for the TextBox controls
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (!string.IsNullOrEmpty(erprvAddContact.GetError(textBox)))
                    {
                        // Error message found for this TextBox
                        return false; // ErrorProvider is not empty
                    }
                }
            }

            return true; // ErrorProvider is empty (no error messages set)
        }


        private void picboxContact_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
