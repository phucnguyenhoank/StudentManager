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

namespace StudentManager
{
    public partial class FrmAddCourseForStudent : Form
    {
        private List<Course> availableCourses;
        private List<Course> selectedCourses;
        private string studentID = null;

        public FrmAddCourseForStudent(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
        }

        private void FrmAddCourseForStudent_Load(object sender, EventArgs e)
        {
            if (studentID != null)
            {
                txtStudentID.Text = studentID;
            }

            cbSelectedSemester.Items.AddRange(new string[] { "1", "2", "3" });
            cbSelectedSemester.SelectedIndex = 0;

            LoadAvailableCourses();
            LoadSelectedCourses();
            cbSelectedSemester_SelectedIndexChanged(sender, e);
        }


        private void cbSelectedSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedCourses(int.Parse(cbSelectedSemester.SelectedItem.ToString()));
        }


        private void LoadAvailableCourses()
        {
            // Lấy danh sách các khóa học có sẵn từ cơ sở dữ liệu
            CourseDAL courseDAL = new CourseDAL();
            DataTable courseList = courseDAL.GetCourseList();

            // Convert DataTable sang List<Course> và gán vào availableCourses
            availableCourses = courseList.AsEnumerable().Select(row => new Course
            {
                CourseID = row.Field<string>("courseID"),
                Label = row.Field<string>("label")
            }).ToList();

            RefreshDataSource();
        }

        private void LoadSelectedCourses(int semester = 0)
        {
            // Lấy danh sách các khóa học đã đăng ký của sinh viên từ cơ sở dữ liệu
            StudentCourseRegistrationDAL studentCourseRegistrationDAL = new StudentCourseRegistrationDAL();
            DataTable studentRegisterCourses = studentCourseRegistrationDAL.GetRegisterCoursesOfStudent(studentID, semester);

            // Convert DataTable sang List<Course> và gán vào selectedCourses
            selectedCourses = studentRegisterCourses.AsEnumerable().Select(row => new Course
            {
                CourseID = row.Field<string>("courseID"),
                Label = row.Field<string>("label")
            }).ToList();
            RefreshDataSource();
        }

        private void RefreshDataSource()
        {
            // Refresh the data sources
            lbxAvailableCourse.DataSource = null;
            lbxAvailableCourse.DataSource = availableCourses;
            lbxAvailableCourse.DisplayMember = "label";
            lbxAvailableCourse.ValueMember = "courseID";

            lbxSelectedCourse.DataSource = null;
            lbxSelectedCourse.DataSource = selectedCourses;
            lbxSelectedCourse.DisplayMember = "label";
            lbxSelectedCourse.ValueMember = "courseID";
        }

        


        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            this.studentID = txtStudentID.Text;
            erprvAddCourseForStudent.Clear(); // Clear any previous error messages

            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                erprvAddCourseForStudent.SetError(txtStudentID, "Student ID cannot be empty.");
                return;
            }

            StudentDAL studentDAL = new StudentDAL();

            // Check if the student exists
            if (!studentDAL.HaveStudent(txtStudentID.Text))
            {
                erprvAddCourseForStudent.SetError(txtStudentID, "Student not found.");
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if there's any error associated with the txtStudentID using ErrorProvider
            if (string.IsNullOrEmpty(txtStudentID.Text) || erprvAddCourseForStudent.GetError(txtStudentID) != "" || lbxSelectedCourse.Items.Count == 0)
            {
                MessageBox.Show("Please enter valid information before proceeding.");
                return;
            }

            try
            {
                // Get the student ID from the txtStudentID TextBox
                string studentID = txtStudentID.Text;
                int semester = int.Parse(cbSelectedSemester.SelectedItem.ToString());

                // Create a new StudentCourseRegistrationDAL object
                StudentCourseRegistrationDAL registrationDAL = new StudentCourseRegistrationDAL();

                // For each Course in the lbxSelectedCourse ListBox
                foreach (Course course in lbxSelectedCourse.Items)
                {
                    // Create a new StudentCourseRegistration object
                    StudentCourseRegistration registration = new StudentCourseRegistration(studentID, course.CourseID, semester);

                    // Add the registration to the database
                    registrationDAL.AddRegistration(registration);
                }

                MessageBox.Show("Courses saved successfully for the student.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnSave_Click:{ex.Message}");
            }
        }

        private bool ContainsCourse(Course course)
        {
            foreach (Course c in selectedCourses)
            {
                if (c.CourseID == course.CourseID) return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxAvailableCourse.SelectedItem != null)
                {
                    var selectedItem = (Course)lbxAvailableCourse.SelectedItem;

                    StudentCourseRegistrationDAL studentCourseRegistrationDAL = new StudentCourseRegistrationDAL();
                    if (studentCourseRegistrationDAL.HaveRegistration(txtStudentID.Text, selectedItem.CourseID, int.Parse(cbSelectedSemester.SelectedItem.ToString())))
                    {
                        MessageBox.Show("Đăng ký đã tồn tại");
                    }
                    else if (ContainsCourse(selectedItem))
                    {
                        MessageBox.Show("Khóa học đã được thêm vào danh sách chọn rồi");
                    }
                    else
                    {
                        selectedCourses.Add(selectedItem);
                        RefreshDataSource();
                    }
                        
                    

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnAdd_Click:{ex.Message}");
            }
        }

        private void btnUnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxSelectedCourse.SelectedItem != null)
                {
                    var selectedItem = (Course)lbxSelectedCourse.SelectedItem;

                    selectedCourses.Remove(selectedItem);
                    RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnUnAdd_Click:{ex.Message}");
            }
        }

        
    }
}
