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
    public partial class FrmAvgScoreByCourse : Form
    {
        public FrmAvgScoreByCourse()
        {
            InitializeComponent();
        }

        private void SetDTGVColumnNames()
        {
            dtgvAvgScore.Columns["CourseName"].HeaderText = "Tên môn";
            dtgvAvgScore.Columns["AverageScore"].HeaderText = "Điểm TB";
        }

        private void LoadData()
        {
            ScoreDAL scoreDAL = new ScoreDAL();
            dtgvAvgScore.DataSource = scoreDAL.AvgScore();
            SetDTGVColumnNames();
        }

        private void FrmAvgScoreByCourse_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
