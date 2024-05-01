using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace StudentManager
{
    public partial class FrmManageCourse : Form
    {
        private string contactID = null;
        public FrmManageCourse(string teachID = null)
        {
            InitializeComponent();
            this.contactID = teachID;
        }

        private void LoadCourseList()
        {
            CourseDAL courseDAL = new CourseDAL();
            lbxCourseList.DataSource = courseDAL.GetCourseList();
            lbxCourseList.DisplayMember = "label";
            lblTotalCourse.Text = $"Total course: {lbxCourseList.Items.Count}";
        }

        private void LoadCourseListForTeacher()
        {
            CourseDAL courseDAL = new CourseDAL();
            lbxCourseList.DataSource = courseDAL.GetCourseListByContactID(contactID);
            lbxCourseList.DisplayMember = "label";
            lblTotalCourse.Text = $"Total course: {lbxCourseList.Items.Count}";
        }

        private void FrmManageCourse_Load(object sender, EventArgs e)
        {
            if (contactID == null)
            {
                LoadCourseList();
            }
            else
            {
                LoadCourseListForTeacher();
            }
            
        }

        private void lbxCourseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)lbxCourseList.SelectedItem;
            txtID.Text = row["courseID"].ToString();
            txtLabel.Text = row["label"].ToString();
            nudHoursNumber.Value = int.Parse(row["period"].ToString());
            txtDescription.Text = row["description"].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (lbxCourseList.Items.Count > 0)
                lbxCourseList.SelectedIndex = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lbxCourseList.SelectedIndex > 0)
                lbxCourseList.SelectedIndex--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lbxCourseList.SelectedIndex < lbxCourseList.Items.Count - 1)
                lbxCourseList.SelectedIndex++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (lbxCourseList.Items.Count > 0)
                lbxCourseList.SelectedIndex = lbxCourseList.Items.Count - 1;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseId = txtID.Text;
            string courseLabel = txtLabel.Text;
            int coursePeriod = (int)nudHoursNumber.Value;
            string courseDescription = txtDescription.Text;

            frmAddCourse addCourseForm = new frmAddCourse(courseId, courseLabel, coursePeriod, courseDescription);
            addCourseForm.ShowDialog();

            LoadCourseList();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            string courseId = txtID.Text;
            FrmRemoveCourse removeCourseForm = new FrmRemoveCourse(courseId);
            removeCourseForm.ShowDialog();

            LoadCourseList();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            string courseId = txtID.Text;

            FrmEditCourse editCourseForm = new FrmEditCourse(courseId);
            editCourseForm.ShowDialog();

            LoadCourseList();
        }

        private void btnCourseDetails_Click(object sender, EventArgs e)
        {
            FrmCourseStudentList frmCourseStudentList = new FrmCourseStudentList(txtID.Text);
            frmCourseStudentList.ShowDialog(this);
        }
    }
}
