using DTO;
using DAL;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace StudentManager
{
    public partial class FrmEditCourse : Form
    {
        private System.Data.DataTable courseTable = null;


        private string courseId;

        public FrmEditCourse(string courseId = "")
        {
            InitializeComponent();

            this.courseId = courseId;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            if (comboBoxCourses.Items.Count == 0)
            {
                errorProvider.SetError(comboBoxCourses, "Add more course before editing");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(comboBoxCourses, "");
            }

            if (string.IsNullOrWhiteSpace(txtEditedLabel.Text))
            {
                errorProvider.SetError(txtEditedLabel, "Label is required");
                isValid = false;
            }
            else if (Regex.IsMatch(txtEditedLabel.Text, @"\d"))
            {
                errorProvider.SetError(txtEditedLabel, "Label cannot contain numbers");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtEditedLabel, "");
            }

            if (!((int)numericUpDownPeriod.Value > 10))
            {
                errorProvider.SetError(numericUpDownPeriod, "period must lager than 10");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(numericUpDownPeriod, "");
            }


            if (string.IsNullOrWhiteSpace(txtEditedDescription.Text))
            {
                errorProvider.SetError(txtEditedDescription, "Description is required");
                isValid = false;
            }
            else
            {
                errorProvider.SetError(txtEditedDescription, "");
            }



            return isValid;
        }

        private void FrmEditCourse_Load(object sender, EventArgs e)
        {
            ValidateInputs();

            CourseDAL courseDAL = new CourseDAL();
            courseTable = courseDAL.GetCourseList();

            comboBoxCourses.DataSource = courseTable;
            comboBoxCourses.DisplayMember = "courseID";
            comboBoxCourses.ValueMember = "courseID";

            if (string.IsNullOrEmpty(this.courseId))
            {
                // Lấy giá trị của cột từ hàng đầu tiên của DataTable
                txtEditedLabel.Text = courseTable.Rows[0]["label"].ToString();
                numericUpDownPeriod.Value = Convert.ToInt32(courseTable.Rows[0]["period"]);
                txtEditedDescription.Text = courseTable.Rows[0]["description"].ToString();
            }
            else
            {
                // Tìm dòng có courseID tương ứng với this.courseId
                DataRow[] foundRows = courseTable.Select($"courseID = '{this.courseId}'");

                if (foundRows.Length > 0)
                {
                    // Chọn mục trong comboBoxCourses tương ứng với courseID được tìm thấy
                    comboBoxCourses.SelectedValue = this.courseId;

                    // Lấy thông tin từ dòng tìm được và gán vào các điều khiển trên giao diện
                    txtEditedLabel.Text = foundRows[0]["label"].ToString();
                    numericUpDownPeriod.Value = Convert.ToInt32(foundRows[0]["period"]);
                    txtEditedDescription.Text = foundRows[0]["description"].ToString();
                }
                else
                {
                    // Hiển thị thông báo khi không tìm thấy courseID tương ứng
                    MessageBox.Show($"Course with ID '{this.courseId}' not found.");
                }
            }
        }


        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCourses.SelectedItem != null && comboBoxCourses.SelectedItem is DataRowView)
            {
                DataRowView selectedRow = comboBoxCourses.SelectedItem as DataRowView;
                string selectedId = selectedRow["courseID"].ToString();

                // Lấy các giá trị khác từ cột khác của hàng được chọn
                string selectedLabel = selectedRow["label"].ToString();
                int selectedPeriod = Convert.ToInt32(selectedRow["period"]);
                string selectedDescription = selectedRow["description"].ToString();

                // Hiển thị các giá trị đã lấy lên các control khác
                txtEditedLabel.Text = selectedLabel;
                numericUpDownPeriod.Value = selectedPeriod;
                txtEditedDescription.Text = selectedDescription;
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            try
            {

                if (!ValidateInputs())
                {
                    MessageBox.Show("Your input in not valid, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (comboBoxCourses.SelectedItem != null && comboBoxCourses.SelectedItem is DataRowView)
                    {
                        DataRowView selectedRow = comboBoxCourses.SelectedItem as DataRowView;
                        string courseId = selectedRow["courseID"].ToString();

                        // Tạo đối tượng Course mới từ các giá trị nhập vào
                        Course newCourse = new Course();
                        newCourse.CourseID = courseId; // Sử dụng courseId lấy từ mục đã chọn trong ComboBox
                        newCourse.Label = txtEditedLabel.Text;
                        newCourse.Period = (int)numericUpDownPeriod.Value;
                        newCourse.Description = txtEditedDescription.Text;

                        // Gọi phương thức EditCourse để chỉnh sửa khóa học
                        CourseDAL courseDAL = new CourseDAL();
                        if (courseDAL.EditCourse(courseId, newCourse))
                        {
                            // Nếu chỉnh sửa thành công, cập nhật lại dữ liệu trong ComboBox
                            LoadDataIntoComboBox(courseId);
                            MessageBox.Show("Chỉnh sửa khóa học thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể chỉnh sửa khóa học!");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnEditCourse_Click:{ex.Message}");
            }
            
        }

        private void LoadDataIntoComboBox(string courseId)
        {
            try
            {
                CourseDAL courseDAL = new CourseDAL();
                courseTable = courseDAL.GetCourseList();

                comboBoxCourses.DataSource = courseTable;
                comboBoxCourses.DisplayMember = "courseID";

                foreach (DataRowView item in comboBoxCourses.Items)
                {
                    if (item["courseID"].ToString() == courseId)
                    {
                        comboBoxCourses.SelectedItem = item;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể nạp dữ liệu cho ComboBox: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownPeriod_ValueChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtEditedLabel_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void txtEditedDescription_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}
