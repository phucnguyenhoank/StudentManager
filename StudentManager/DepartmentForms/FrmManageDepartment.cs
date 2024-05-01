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
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Data.SqlClient;

namespace StudentManager.DepartmentForms
{
    public partial class FrmManageDepartment : Form
    {
        public FrmManageDepartment()
        {
            InitializeComponent();
        }

        private bool NotHaveAnyErrorMessageInErrorProvider()
        {
            return string.IsNullOrEmpty(erprvDpmMng.GetError(txtAddedDepartment));
        }

        private void LoadDataGridView()
        {
            DepartmentDAL departmentDAL = new DepartmentDAL();
            dtgvDepartment.DataSource = departmentDAL.GetAllDepartmentsAsDataTable();
            dtgvDepartment.Columns["departmentID"].HeaderText = "Department ID";
            dtgvDepartment.Columns["departmentName"].HeaderText = "Department Name";
        }



        private void FrmManageDepartment_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadDepartmentsIntoComboBoxs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAddedDepartment.Text))
                {
                    MessageBox.Show("Empty string");
                }
                else if (!NotHaveAnyErrorMessageInErrorProvider())
                {
                    MessageBox.Show("Please enter valid information");
                    
                }
                else
                {
                    DepartmentDAL departmentDAL = new DepartmentDAL();
                    departmentDAL.AddDepartment(new Department(0, txtAddedDepartment.Text));
                    MessageBox.Show("Added Successfully");
                    LoadDataGridView();
                    LoadDepartmentsIntoComboBoxs();
                }

            

            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnAdd_Click:{ex.Message}");
            }
        }

        private void txtAddedDepartment_TextChanged(object sender, EventArgs e)
        {
            DepartmentDAL departmentDAL = new DepartmentDAL();
            if (departmentDAL.DepartmentExists(txtAddedDepartment.Text))
            {
                erprvDpmMng.SetError(txtAddedDepartment, "Exited Department");
            }
            else
            {
                erprvDpmMng.SetError(txtAddedDepartment, "");
            }
        }

        private void LoadDepartmentsIntoComboBoxs()
        {
            DepartmentDAL departmentDAL = new DepartmentDAL();

            try
            {
                List<Department> allDepartments1 = departmentDAL.GetAllDepartmentsAsList();
                List<Department> allDepartments2 = departmentDAL.GetAllDepartmentsAsList();

                cbRemovedDepartment.DataSource = allDepartments1;
                cbRemovedDepartment.DisplayMember = "DepartmentName"; // Hiển thị tên phòng ban trong ComboBox
                cbRemovedDepartment.ValueMember = "DepartmentID"; // Giá trị của mỗi phần tử trong ComboBox

                cbEditedDepartment.DataSource = allDepartments2;
                cbEditedDepartment.DisplayMember = "DepartmentName"; // Hiển thị tên phòng ban trong ComboBox
                cbEditedDepartment.ValueMember = "DepartmentID"; // Giá trị của mỗi phần tử trong ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadDepartmentsIntoComboBoxs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbRemovedDepartment.SelectedItem != null)
            {
                Department selectedDepartment = cbRemovedDepartment.SelectedItem as Department;
                int departmentID = selectedDepartment.DepartmentID;
                string departmentName = selectedDepartment.DepartmentName;

                DepartmentDAL departmentDAL = new DepartmentDAL();

                try
                {
                    // Xóa phòng ban khỏi cơ sở dữ liệu
                    int rowsAffected = departmentDAL.DeleteDepartment(departmentID);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Department '{departmentName}' has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataGridView();
                        LoadDepartmentsIntoComboBoxs();
                        
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete department '{departmentName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (cbEditedDepartment.SelectedItem != null)
            {
                Department selectedDepartment = cbEditedDepartment.SelectedItem as Department;
                int departmentID = selectedDepartment.DepartmentID;
                string departmentName = selectedDepartment.DepartmentName;

                DepartmentDAL departmentDAL = new DepartmentDAL();

                try
                {
                    // Xóa phòng ban khỏi cơ sở dữ liệu
                    int rowsAffected = departmentDAL.EditDepartment(departmentName, txtEditedDepartment.Text);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Department '{departmentName}' has been edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDataGridView();
                        LoadDepartmentsIntoComboBoxs();
                        
                    }
                    else
                    {
                        MessageBox.Show($"Failed to edit department '{departmentName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error editing department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a department to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
