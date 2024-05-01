using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentManager
{
    public partial class FrmAddScore : Form
    {
        public FrmAddScore()
        {
            InitializeComponent();
        }

        private void LoadToCBCourseLabel()
        {
            CourseDAL courseDAL = new CourseDAL();
            cbCourseLabel.DataSource = courseDAL.GetCourseList(txtStudentID.Text, int.Parse(cbSemester.SelectedItem.ToString()));
            cbCourseLabel.DisplayMember = "label";
            cbCourseLabel.ValueMember = "courseID";
        }

        private void LoadData()
        {
            

            StudentDAL studentDAL = new StudentDAL();
            dtgvScoreStudent.DataSource = studentDAL.GetStudentList();
            dtgvScoreStudent.Columns["studentID"].HeaderText = "MSSV";
            dtgvScoreStudent.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
            dtgvScoreStudent.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
            dtgvScoreStudent.Columns["phoneNumber"].HeaderText = "SĐT";
            dtgvScoreStudent.Columns["birthday"].HeaderText = "Ngày sinh"; // Đổi tên cột birthday
            dtgvScoreStudent.Columns["gender"].HeaderText = "Giới tính";
            dtgvScoreStudent.Columns["address"].HeaderText = "Địa chỉ";
            dtgvScoreStudent.Columns["image"].HeaderText = "Ảnh";

            // Đổi cách hiển thị
            dtgvScoreStudent.Columns["birthday"].DefaultCellStyle.Format = "MM/dd/yyyy";
            ((DataGridViewImageColumn)dtgvScoreStudent.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;


            cbSemester.DataSource = new List<string> { "1", "2", "3" };
            cbSemester.SelectedIndex = 0;

            LoadToCBCourseLabel();


        }

        public bool IsValidPositiveDecimalAndInRange(string input)
        {
            if (double.TryParse(input, out double result))
            {
                return result >= 0.0 && result <= 10.0;
            }
            else
            {
                return false;
            }
        }


        private bool ValidateInputs()
        {
            bool isValid = true;
            StudentDAL studentDAL = new StudentDAL();

            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                errorProvider.SetError(txtStudentID, "Student ID is required");
                isValid = false;
            }
            else if (!studentDAL.HaveStudent(txtStudentID.Text))
            {
                errorProvider.SetError(txtStudentID, "Student ID does NOT exist");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtStudentID, "");
            }

            if (cbCourseLabel.Items.Count == 0)
            {
                errorProvider.SetError(cbCourseLabel, "There is no register course to add score");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(cbCourseLabel, "");
            }

            StudentCourseRegistrationDAL studentCourseRegistrationDAL = new StudentCourseRegistrationDAL();
            if (cbCourseLabel.Items.Count == 0)
            {
                errorProvider.SetError(cbCourseLabel, "There is no register course to add score");
                isValid = false;
            }
            else if (!studentCourseRegistrationDAL.HaveRegistration(txtStudentID.Text, cbCourseLabel.SelectedValue.ToString(), int.Parse(cbSemester.SelectedItem.ToString())))
            {
                errorProvider.SetError(cbSemester, "Does not have any registration like this to Score");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(cbSemester, "");
            }

            if (!IsValidPositiveDecimalAndInRange(txtScore.Text))
            {
                errorProvider.SetError(txtScore, "Score must be a decimal number in range [0.0, 10.0]");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtScore, "");
            }

            if (string.IsNullOrWhiteSpace(txtScoreDescription.Text))
            {
                errorProvider.SetError(txtScoreDescription, "Description is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtScoreDescription, "");
            }

            return isValid;
        }

        private void FrmAddScore_Load(object sender, EventArgs e)
        {
            LoadData();
            ValidateInputs();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                ScoreDAL scoreDAL = new ScoreDAL();
                if (!ValidateInputs())
                {
                    MessageBox.Show("Your input in not valid, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (scoreDAL.HaveScore(txtStudentID.Text, cbCourseLabel.SelectedValue.ToString(), int.Parse(cbSemester.SelectedItem.ToString())))
                {
                    MessageBox.Show("Existing Score", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Lấy thông tin từ các điều khiển trên giao diện
                    string studentId = txtStudentID.Text;
                    string courseId = cbCourseLabel.SelectedValue.ToString(); // Lấy giá trị được chọn từ ComboBox
                    decimal studentScore = decimal.Parse(txtScore.Text);
                    string description = txtScoreDescription.Text;

                    // Tạo đối tượng Score từ thông tin đã lấy
                    Score newScore = new Score(studentId, courseId, int.Parse(cbSemester.SelectedItem.ToString()),studentScore, description);
                    
                    
                    // Gọi hàm AddScore để thêm điểm vào cơ sở dữ liệu
                    scoreDAL.AddScore(newScore);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Đã thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {       
                
                Console.WriteLine($"btnAddScore_Click:{ex.Message}");

                MessageBox.Show("Đã xảy ra lỗi khi thêm điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtScoreDescription_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadToCBCourseLabel();
            ValidateInputs();
        }
    }
}
