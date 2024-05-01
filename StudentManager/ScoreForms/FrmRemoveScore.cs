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
    public partial class FrmRemoveScore : Form
    {
        public FrmRemoveScore()
        {
            InitializeComponent();
        }

        private void SetNameScoreList()
        {
            dtgvScoreList.Columns["studentID"].HeaderText = "MSSV";
            dtgvScoreList.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
            dtgvScoreList.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
            dtgvScoreList.Columns["courseID"].HeaderText = "Mã môn";
            dtgvScoreList.Columns["label"].HeaderText = "Tên môn"; // Đổi tên cột birthday
            dtgvScoreList.Columns["studentScore"].HeaderText = "Điểm";
            dtgvScoreList.Columns["semester"].HeaderText = "Học kỳ";
        }

        private void LoadData()
        {
            ScoreDAL scoreDAL = new ScoreDAL();
            dtgvScoreList.DataSource = scoreDAL.GetStudentScoreCourseList();
            SetNameScoreList();
            

        }

        private void FrmRemoveScore_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected row index
                int rowIndex = dtgvScoreList.CurrentCell.RowIndex;

                // Get the studentID of the selected row
                string studentID = dtgvScoreList.Rows[rowIndex].Cells["studentID"].Value.ToString();
                string courseID = dtgvScoreList.Rows[rowIndex].Cells["courseID"].Value.ToString();
                int semester = int.Parse(dtgvScoreList.Rows[rowIndex].Cells["semester"].Value.ToString());

                // Show a confirmation message before deleting
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa điểm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ScoreDAL scoreDAL = new ScoreDAL();
                    scoreDAL.RemoveScore(studentID, courseID, semester);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Đã xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine($"[btnRemoveScore_Click:{ex.Message}]");
                MessageBox.Show("Đã xảy ra lỗi khi xóa điểm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
