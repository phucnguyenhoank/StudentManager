using DAL;
using DTO;
using StudentManager.StudentForms;
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
    public partial class FrmShowFullList : Form
    {
        private List<Contact> allContacts; // List to hold all contacts

        public FrmShowFullList()
        {
            InitializeComponent();
        }

        private void LoadDepartmentToComboBox()
        {
            DepartmentDAL departmentDAL = new DepartmentDAL();
            try
            {
                // Get all departments
                List<Department> allDepartments = departmentDAL.GetAllDepartmentsAsList();

                // Create a new list to hold departments including the "None" option
                List<Department> departmentsWithNone = new List<Department>(allDepartments);

                // Add a new Department object for "None" option
                departmentsWithNone.Insert(0, new Department { DepartmentID = 0, DepartmentName = "None" });

                // Bind the combo box to the new list
                cbDepartmentName.DataSource = departmentsWithNone;
                cbDepartmentName.DisplayMember = "DepartmentName";
                cbDepartmentName.ValueMember = "DepartmentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadDepartmentToComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataIntoContactGridView()
        {
            ContactDAL contactDAL = new ContactDAL();
            allContacts = contactDAL.GetContactsAsList(); // Get all contacts and store in a list
            dtgvContact.DataSource = allContacts;
            // Customize DataGridView columns
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

        private void FrmShowFullList_Load(object sender, EventArgs e)
        {
            LoadDataIntoContactGridView();
            LoadDepartmentToComboBox();
        }

        private void cbDepartmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartmentName.SelectedValue != null)
            {
                Department selectedDepartment = cbDepartmentName.SelectedItem as Department;

                if (selectedDepartment.DepartmentID == 0)
                {
                    // User selected "None", show all contacts
                    dtgvContact.DataSource = allContacts;
                }
                else
                {
                    // Filter contacts based on the selected DepartmentID
                    List<Contact> filteredContacts = allContacts.Where(c => c.DepartmentID == selectedDepartment.DepartmentID).ToList();

                    // Update the DataGridView with the filtered contacts
                    dtgvContact.DataSource = filteredContacts;
                }
            }
        }

        public static DataTable ConvertToDataTable(List<Contact> contacts)
        {
            DataTable dt = new DataTable();

            // Add columns
            dt.Columns.Add("ContactID", typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("DepartmentID", typeof(int));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Picture", typeof(byte[]));

            // Add rows
            foreach (var contact in contacts)
            {
                dt.Rows.Add(contact.ContactID, contact.FirstName, contact.LastName, contact.DepartmentID, contact.PhoneNumber, contact.Email, contact.Address, contact.Picture);
            }

            return dt;
        }




        private void btnToPrinter_Click(object sender, EventArgs e)
        {
            ContactDAL contactDAL = new ContactDAL();
            FrmSharedPrinter frmSharedPrinter = new FrmSharedPrinter(ConvertToDataTable(dtgvContact.DataSource as List<Contact>), "Contact");
            frmSharedPrinter.ShowDialog();
        }

        private void dtgvContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgvContact.Rows[e.RowIndex];
                    string contactID = row.Cells["contactID"].Value.ToString();

                    FrmManageCourse frmManageCourse = new FrmManageCourse(contactID);
                    frmManageCourse.ShowDialog(this);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"dtgvContact_CellDoubleClick:{ex.Message}");
            }
        }
    }

}
