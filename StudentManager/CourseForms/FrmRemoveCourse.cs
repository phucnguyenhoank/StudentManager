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
    public partial class FrmRemoveCourse : Form
    {
        private string courseId;

        public FrmRemoveCourse(string courseId = "")
        {
            InitializeComponent();

            this.courseId = courseId;

            // Đặt giá trị cho control
            txtRemovedCourseID.Text = courseId;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            CourseDAL courseDAL = new CourseDAL();
            if (string.IsNullOrWhiteSpace(txtRemovedCourseID.Text))
            {
                errorProvider.SetError(txtRemovedCourseID, "Course ID is required");
                isValid = false;
            }
            else if (!courseDAL.HaveCourse(txtRemovedCourseID.Text))
            {
                errorProvider.SetError(txtRemovedCourseID, "Course ID does NOT exist");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtRemovedCourseID, "");
            }
            return isValid;
        }


        private void frmRemoveCourse_Load(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
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
                    courseDAL.RemoveCourse(txtRemovedCourseID.Text);
                    MessageBox.Show($"The course {txtRemovedCourseID.Text} is removed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[btnRemoveCourse_Click{ex.Message}]");
            }
        }

        private void txtRemovedCourseID_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}
