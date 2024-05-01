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

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void btnCancelAddStudent_Click(object sender, EventArgs e)
        {
            Close();
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

        private bool HaveAnyErrorMessageInErrorProvider()
        {
            return !string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentFirstName)) ||
                !string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentLastName)) ||
                !string.IsNullOrEmpty(errorProviderUserInput.GetError(txtStudentPhoneNumber)) ||
                !string.IsNullOrEmpty(errorProviderUserInput.GetError(dtpStudentBirthday));
        }

        private bool OldEnough()
        {
            int age = CalculateAge(this.dtpStudentBirthday.Value);

            return age > 10;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (HaveAnyErrorMessageInErrorProvider())
            {
                MessageBox.Show("Please enter valid information");
            }
            else if (picboxStudentImage.Image == null)
            {
                MessageBox.Show("Please enter the image");
            }
            else if (!OldEnough())
            {
                MessageBox.Show("Your are too young");
            }
            else
            {

                try
                {

                    string studentID = txtStudentID.Text;
                    string firstStudentName = txtStudentFirstName.Text;
                    string lastStudentName = txtStudentLastName.Text;
                    string phoneNumber = txtStudentPhoneNumber.Text;
                    DateTime studentBirthday = dtpStudentBirthday.Value.Date;
                    string gender = (rbtnAddStudentGenderMale.Checked) ? "Male" : "Female";
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


        }

        private void picboxStudentImage_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            StudentDAL studentDAL = new StudentDAL();
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                errorProviderUserInput.SetError(txtStudentID, "student ID cannot be empty");
            }
            else if (studentDAL.HaveStudent(txtStudentID.Text))
            {
                errorProviderUserInput.SetError(txtStudentID, "already exited student");
            }
            else
            {
                errorProviderUserInput.SetError(txtStudentID, "");
            }
        }

        private void txtStudentFirstName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentFirstName.Text))
            {
                errorProviderUserInput.SetError(txtStudentFirstName, "first name cannot be empty");
            }
            else if (txtStudentFirstName.Text.Any(char.IsDigit))
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
            if (string.IsNullOrWhiteSpace(txtStudentLastName.Text))
            {
                errorProviderUserInput.SetError(txtStudentLastName, "last name cannot be empty");
            }
            else if (txtStudentLastName.Text.Any(char.IsDigit))
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
            if (string.IsNullOrWhiteSpace(txtStudentPhoneNumber.Text))
            {
                errorProviderUserInput.SetError(txtStudentPhoneNumber, "phone number cannot be empty");
            }
            else if (!int.TryParse(txtStudentPhoneNumber.Text, out _))
            {
                errorProviderUserInput.SetError(txtStudentPhoneNumber, "phone number contains letters, or is too long");
            }
            else
            {
                errorProviderUserInput.SetError(txtStudentPhoneNumber, "");
            }
        }


        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            rbtnAddStudentGenderMale.Checked = true;
            txtStudentID_TextChanged(sender, e);
            txtStudentFirstName_TextChanged(sender, e);
            txtStudentLastName_TextChanged(sender, e);
            txtStudentPhoneNumber_TextChanged(sender, e);
        }

        private int CalculateAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;
            return age;
        }

        private void dtpStudentBirthday_ValueChanged(object sender, EventArgs e)
        {
            int age = CalculateAge(dtpStudentBirthday.Value);
            if (age < 10)
            {
                errorProviderUserInput.SetError(dtpStudentBirthday, "Student age must be 10 or older");
                return;
            }
            else
            {
                errorProviderUserInput.SetError(dtpStudentBirthday, "");
            }
        }

        
    }
}
