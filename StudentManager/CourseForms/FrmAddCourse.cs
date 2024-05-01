using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace StudentManager
{
    public partial class frmAddCourse : Form
    {
        private string courseId;
        private string courseLabel;
        private int coursePeriod;
        private string courseDescription;

        public frmAddCourse(string courseId = "", string courseLabel = "", int coursePeriod = 11, string courseDescription = "")
        {
            InitializeComponent();

            this.courseId = courseId;
            this.courseLabel = courseLabel;
            this.coursePeriod = coursePeriod;
            this.courseDescription = courseDescription;

            // Đặt giá trị cho các control
            txtCourseID.Text = courseId;
            txtCourseLabel.Text = courseLabel;
            txtCoursePeriod.Text = coursePeriod.ToString();
            txtCourseDescription.Text = courseDescription;
        }

        public bool IsValidPositiveIntegerAndGreaterThan10(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result > 10;
            }
            else
            {
                return false;
            }
        }


        private bool ValidateInputs()
        {
            bool isValid = true;
            CourseDAL courseDAL = new CourseDAL();
            if (string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                errorProvider.SetError(txtCourseID, "Course ID is required");
                isValid = false;
            }
            else if (courseDAL.HaveCourse(txtCourseID.Text))
            {
                errorProvider.SetError(txtCourseID, "Course ID already existed");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtCourseID, "");
            }

            if (string.IsNullOrWhiteSpace(txtCourseLabel.Text))
            {
                errorProvider.SetError(txtCourseLabel, "Label is required");
                isValid = false;
            }
            else if (Regex.IsMatch(txtCourseLabel.Text, @"\d"))
            {
                errorProvider.SetError(txtCourseLabel, "Label cannot contain numbers");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtCourseLabel, "");
            }

            if (string.IsNullOrWhiteSpace(txtCoursePeriod.Text))
            {
                errorProvider.SetError(txtCoursePeriod, "Course Period is required");
                isValid = false;
            }
            else if (!IsValidPositiveIntegerAndGreaterThan10(txtCoursePeriod.Text))
            {
                errorProvider.SetError(txtCoursePeriod, "Course Period must be a greater than 10 integer");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtCoursePeriod, "");
            }

            if (string.IsNullOrWhiteSpace(txtCourseDescription.Text))
            {
                errorProvider.SetError(txtCourseDescription, "Description is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtCourseDescription, "");
            }

            return isValid;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            try
            {
                if (!ValidateInputs())
                {
                    MessageBox.Show("Your input in not valid, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    CourseDAL courseDAL = new CourseDAL();
                    courseDAL.AddCourse(new DTO.Course(txtCourseID.Text, txtCourseLabel.Text, int.Parse(txtCoursePeriod.Text), txtCourseDescription.Text));
                    MessageBox.Show($"Course {txtCourseID.Text} Added");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"[btnAddCourse_Click:{ex.Message}]");
            }
        }

        

        

        private void txtCourseID_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }


        private void txtCourseLabel_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtCoursePeriod_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtCourseDescription_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}
