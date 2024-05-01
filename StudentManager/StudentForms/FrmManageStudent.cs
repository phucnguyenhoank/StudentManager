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
using DAL;
using Microsoft.Office.Interop.Word;

namespace StudentManager
{
    public partial class FrmManageStudent : Form
    {
        public FrmManageStudent()
        {
            InitializeComponent();
        }

        private void btnUploadStudentPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png)|*.jpg;*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picboxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDAL studentDAL = new StudentDAL();
                dtgvSearchStudentList.DataSource = studentDAL.GetStudentInCondition($"CONCAT(firstName, lastName, address) LIKE N'%{txtSearchStringInput.Text}%'");

                dtgvSearchStudentList.Columns["studentID"].HeaderText = "MSSV";
                dtgvSearchStudentList.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
                dtgvSearchStudentList.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
                dtgvSearchStudentList.Columns["phoneNumber"].HeaderText = "SĐT";
                dtgvSearchStudentList.Columns["birthday"].HeaderText = "Ngày sinh"; // Đổi tên cột birthday
                dtgvSearchStudentList.Columns["gender"].HeaderText = "Giới tính";
                dtgvSearchStudentList.Columns["address"].HeaderText = "Địa chỉ";
                dtgvSearchStudentList.Columns["image"].HeaderText = "Ảnh";

                // Đổi cách hiển thị
                dtgvSearchStudentList.Columns["birthday"].DefaultCellStyle.Format = "MM/dd/yyyy";
                
                ((DataGridViewImageColumn)dtgvSearchStudentList.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                btnTotalStudent_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"StudentManager\\btnSearchStudent_Click:{ex.Message}");
            }
        }

        private void btnCancelManageStudent_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentFirstName)) ||
                !string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentLastName)) ||
                !string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentPhoneNumber)))
            {
                MessageBox.Show("Please enter valid information");
                return;
            }

            try
            {

                string studentID = txtStudentID.Text;
                string firstStudentName = txtStudentFirstName.Text;
                string lastStudentName = txtStudentLastName.Text;
                string phoneNumber = txtStudentPhoneNumber.Text;
                DateTime studentBirthday = dtpStudentBirthday.Value.Date;
                string gender = (rbtnStudentGenderMale.Checked) ? "Male" : "Female";
                string address = txtStudentAddress.Text;

                MemoryStream studentPicMemoryStream = new MemoryStream();
                picboxStudentImage.Image.Save(studentPicMemoryStream, picboxStudentImage.Image.RawFormat);
                byte[] studentImageData = studentPicMemoryStream.ToArray();

                Student addedStudent = new Student(studentID, firstStudentName, lastStudentName, phoneNumber, studentBirthday, gender, address, studentImageData);


                StudentDAL studentBLL = new StudentDAL();
                if (studentBLL.AddStudent(addedStudent))
                {
                    MessageBox.Show("Add Student successfully");
                }
                else
                {
                    MessageBox.Show("The StudentID already exists or some unexpected error occurred", "Add Student failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[btnAddStudent_Click:{ex.Message}]");
            }
        }

        private void txtStudentFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentFirstName.Text.Any(char.IsDigit))
            {
                errorProviderUserInput.SetError(txtStudentFirstName, "first name contains digits");
            }
            else
            {
                errorProviderUserInput.SetError(txtStudentFirstName, "");
            }
        }

        private void txtStudentLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentLastName.Text.Any(char.IsDigit))
            {
                errorProviderUserInput.SetError(txtStudentLastName, "last name contains digits");
            }
            else
            {
                errorProviderUserInput.SetError(txtStudentLastName, "");
            }

        }

        private void txtStudentPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentPhoneNumber.Text, out _))
            {
                errorProviderUserInput.SetError(txtStudentPhoneNumber, "contains letters, empty, or too long");
            }
            else
            {
                errorProviderUserInput.SetError(txtStudentPhoneNumber, "");
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentFirstName)) ||
                !string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentLastName)) ||
                !string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentPhoneNumber))
                )
            {
                MessageBox.Show("Please enter valid information");
                return;
            }

            StudentDAL studentDAL = new StudentDAL();
            if (!studentDAL.HaveStudent(txtStudentID.Text))
            {
                MessageBox.Show("Not exited studentID");
                return;
            }

            try
            {
                StudentDAL db = new StudentDAL();
                DialogResult dialog = MessageBox.Show("Do you really want to edit student who has student ID: " + txtStudentID.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    string studentID = txtStudentID.Text;
                    string firstStudentName = txtStudentFirstName.Text;
                    string lastStudentName = txtStudentLastName.Text;
                    string phoneNumber = txtStudentPhoneNumber.Text;
                    DateTime studentBirthday = dtpStudentBirthday.Value.Date;
                    string gender = (rbtnStudentGenderMale.Checked) ? "Male" : "Female";
                    string address = txtStudentAddress.Text;

                    MemoryStream studentPicMemoryStream = new MemoryStream();
                    picboxStudentImage.Image.Save(studentPicMemoryStream, picboxStudentImage.Image.RawFormat);
                    byte[] studentImageData = studentPicMemoryStream.ToArray();

                    Student newStudent = new Student(studentID, firstStudentName, lastStudentName, phoneNumber, studentBirthday, gender, address, studentImageData);

                    if (db.EditStudent(studentID, newStudent))
                    {
                        MessageBox.Show("Edit successfully");
                    }
                    else
                    {
                        MessageBox.Show("Edit failed");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"[btnEditStudent_Click:{ex.Message}");
            }
        }

        private void dtgvSearchStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    object cellValue = dtgvSearchStudentList.Rows[e.RowIndex].Cells[0].Value;


                    if (dtgvSearchStudentList.Columns[e.ColumnIndex].Name == "SelectedCourses")
                    {
                        DataGridViewRow row = dtgvSearchStudentList.Rows[e.RowIndex];

                        FrmAddCourseForStudent frmAddCourseForStudent = new FrmAddCourseForStudent((string)row.Cells["studentID"].Value);

                        frmAddCourseForStudent.ShowDialog();
                    }
                    // nếu nhấn vào cột id
                    else if (e.ColumnIndex == 0)
                    {

                        System.Data.DataTable dataTable = (new StudentDAL()).GetStudentDataTableByID(cellValue.ToString());

                        DataRow row = dataTable.Rows[0];
                        txtStudentID.Text = row.Field<string>("studentID");
                        txtStudentFirstName.Text = row.Field<string>("firstName");
                        txtStudentLastName.Text = row.Field<string>("lastName");
                        txtStudentPhoneNumber.Text = row.Field<string>("phoneNumber");
                        dtpStudentBirthday.Value = row.Field<DateTime>("birthday");
                        if (row.Field<string>("gender") == "Male")
                        {
                            rbtnStudentGenderMale.Checked = true;
                        }
                        else
                        {
                            rbtnStudentGenderFemale.Checked = true;
                        }

                        txtStudentAddress.Text = row.Field<string>("address");

                        MemoryStream ms = new MemoryStream(row.Field<byte[]>("image"));
                        picboxStudentImage.Image = System.Drawing.Image.FromStream(ms);
                    }
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"dtgvSearchStudentList_CellDoubleClick:{ex.Message}");
            }

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDAL db = new StudentDAL();
                DialogResult dialog = MessageBox.Show("Do you really want to remove student who has student ID: " + txtStudentID.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    if (db.RemoveStudent(txtStudentID.Text))
                    {
                        MessageBox.Show("Remove successfully");
                    }
                    else
                    {
                        MessageBox.Show("Remove failed");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnRemoveStudent_Click:{ex.Message}");
            }
        }

        private void btnResetEntries_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentFirstName.Text = "";
            txtStudentLastName.Text = "";
            txtStudentPhoneNumber.Text = "";
            dtpStudentBirthday.Value = DateTime.Now;
            picboxStudentImage.Image = null;
            txtSearchStringInput.Text = "";


        }

        private void btnTotalStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDAL studentDAL = new StudentDAL();
                lblTotalStudent.Text = $"Total Student: {dtgvSearchStudentList.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnTotalStudent_Click:{ex.Message}");
            }
        }

        private void FrmManageStudent_Load(object sender, EventArgs e)
        {
            // TODO: double click vao cot selected course va mo form add course for student
            btnSearchStudent_Click(sender, e);
            // Create a new column
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = "SelectedCourses";
            column.HeaderText = "Selected courses";

            // Insert the column at the last position
            dtgvSearchStudentList.Columns.Insert(8, column);
        }

        private void dtgvSearchStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
