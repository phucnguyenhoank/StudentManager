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
using StudentManager.DepartmentForms;
using StudentManager.StudentForms;

namespace StudentManager
{
    public partial class FrmFunctionSelector : Form
    {
        public FrmFunctionSelector()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent addStudentForm = new FrmAddStudent();
            addStudentForm.ShowDialog(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentList studentListForm = new FrmStudentList();
            studentListForm.ShowDialog(this);
        }

        private void frmFunctionSelector_Load(object sender, EventArgs e)
        {

        }

        private void birthMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatis frmSta = new FrmStatis();
            frmSta.ShowDialog(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCourse frmAddCourses = new frmAddCourse();
            frmAddCourses.ShowDialog(this);

        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemoveCourse frmRemoveCourses = new FrmRemoveCourse();
            frmRemoveCourses.ShowDialog(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditCourse frmEditCourse = new FrmEditCourse();
            frmEditCourse.ShowDialog(this);
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrintStudent frmPrintStudent = new FrmPrintStudent();
            frmPrintStudent.ShowDialog(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageCourse frmManageCourse = new FrmManageCourse();
            frmManageCourse.ShowDialog(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CourseDAL courseDAL = new CourseDAL();
            FrmSharedPrinter frmSharedPrinter = new FrmSharedPrinter(courseDAL.GetCourseList(), "Course");
            frmSharedPrinter.ShowDialog(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddScore frmAddScore = new FrmAddScore();
            frmAddScore.ShowDialog(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemoveScore frmRemoveScore = new FrmRemoveScore();
            frmRemoveScore.ShowDialog(this);
        }

        private void avgScoreByResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAvgScoreByCourse frmAvgScoreByCourse = new FrmAvgScoreByCourse();
            frmAvgScoreByCourse.ShowDialog(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditRemoveStudent frmEditStudent = new FrmEditRemoveStudent();
            frmEditStudent.ShowDialog(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageStudent frmManageStudent = new FrmManageStudent();
            frmManageStudent.ShowDialog(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageScore frmManageScore = new FrmManageScore();
            frmManageScore.ShowDialog(this);
        }

        private void averageResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResult frmResult = new FrmResult();
            frmResult.ShowDialog(this);
        }

        private void statisticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatisticResult frmStatisticResult = new FrmStatisticResult();
            frmStatisticResult.ShowDialog(this);
        }

        private void manageDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageDepartment frmManageDepartment = new FrmManageDepartment();
            frmManageDepartment.ShowDialog(this);
        }

        private void permissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAccountList accountList = new FrmAccountList();
            accountList.ShowDialog(this);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void humanResourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHumanResourcesManagerSelector frmHumanResourcesManagerSelector = new FrmHumanResourcesManagerSelector();
            frmHumanResourcesManagerSelector.ShowDialog(this);
        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreDAL scoreDAL = new ScoreDAL();
            FrmSharedPrinter frmStudentPrinter = new FrmSharedPrinter(scoreDAL.GetScoreList(), "Score");
            frmStudentPrinter.ShowDialog();
        }
    }
}
