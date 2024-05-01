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

namespace StudentManager
{
    public partial class FrmManageScore : Form
    {
        public FrmManageScore()
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

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Description is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtDescription, "");
            }

            return isValid;
        }


        private void FrmManageScore_Load(object sender, EventArgs e)
        {
            LoadData();
            btnShowScores_Click(sender, e);
            ValidateInputs();
        }

        private void SetNameScoreList()
        {
            dtgvManageScore.Columns["studentID"].HeaderText = "MSSV";
            dtgvManageScore.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
            dtgvManageScore.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
            dtgvManageScore.Columns["courseID"].HeaderText = "Mã môn";
            dtgvManageScore.Columns["label"].HeaderText = "Tên môn"; // Đổi tên cột birthday
            dtgvManageScore.Columns["studentScore"].HeaderText = "Điểm";
        }

        private void SetDTGVAsScores()
        {
            ScoreDAL scoreDAL = new ScoreDAL();
            dtgvManageScore.DataSource = scoreDAL.GetStudentScoreCourseList();
            SetNameScoreList();
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            SetDTGVAsScores();
        }

        private void SetNameStudentList()
        {
            dtgvManageScore.Columns["studentID"].HeaderText = "MSSV";
            dtgvManageScore.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
            dtgvManageScore.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
            dtgvManageScore.Columns["phoneNumber"].HeaderText = "SĐT";
            dtgvManageScore.Columns["birthday"].HeaderText = "Ngày sinh"; // Đổi tên cột birthday
            dtgvManageScore.Columns["gender"].HeaderText = "Giới tính";
            dtgvManageScore.Columns["address"].HeaderText = "Địa chỉ";
            dtgvManageScore.Columns["image"].HeaderText = "Ảnh";

            dtgvManageScore.Columns["birthday"].DefaultCellStyle.Format = "MM/dd/yyyy";
            ((DataGridViewImageColumn)dtgvManageScore.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void SetDTGVAsStudents()
        {
            StudentDAL studentDAL = new StudentDAL();
            dtgvManageScore.DataSource = studentDAL.GetStudentList();
            SetNameStudentList();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            SetDTGVAsStudents();
        }

        private void btnAvgScore_Click(object sender, EventArgs e)
        {
            FrmAvgScoreByCourse frmAvgScoreByCourse = new FrmAvgScoreByCourse();
            frmAvgScoreByCourse.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ScoreDAL scoreDAL = new ScoreDAL();
                if (!ValidateInputs())
                {
                    MessageBox.Show("Please fill in valid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else if (scoreDAL.HaveScore(txtStudentID.Text, cbCourseLabel.SelectedValue.ToString(), int.Parse(cbSemester.SelectedItem.ToString())))
                {
                    MessageBox.Show("Existing Score", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else
                {
                    string studentId = txtStudentID.Text;
                    string courseId = cbCourseLabel.SelectedValue.ToString();
                    int semester = int.Parse(cbSemester.SelectedItem.ToString());
                    decimal studentScore = decimal.Parse(txtScore.Text);
                    string description = txtDescription.Text;

                    Score newScore = new Score(studentId, courseId, semester, studentScore, description);
                    scoreDAL.AddScore(newScore);

                    MessageBox.Show("Đã thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"[btnAddScore_Click:{ex.Message}]", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridViewRow row = dtgvManageScore.CurrentRow;
                if (row != null)
                {
                    DataGridViewCell cell = row.Cells[3];

                    if (cell.OwningColumn.Name == "courseID")
                    {
                        ScoreDAL scoreDAL = new ScoreDAL();

                        // Ask the user for confirmation
                        DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this score?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmation == DialogResult.Yes)
                        {
                            // Attempt to remove the score
                            if (scoreDAL.RemoveScore(row.Cells[0].Value.ToString(), row.Cells[3].Value.ToString(), int.Parse(cbSemester.SelectedItem.ToString())) == 1)
                            {
                                MessageBox.Show("Xóa điểm thành công");
                                SetDTGVAsScores();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No row is selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
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
