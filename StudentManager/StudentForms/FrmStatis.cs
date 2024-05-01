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
using System.Windows.Forms.DataVisualization.Charting;
using DAL;

namespace StudentManager
{
    public partial class FrmStatis : Form
    {
        public FrmStatis()
        {
            InitializeComponent();
        }

        private void frmStatis_Load(object sender, EventArgs e)
        {
            StudentDAL studentDAL = new StudentDAL();
            // Tạo một đối tượng Series mới
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Number of students");

            // Thêm dữ liệu vào Series
            for (int i = 1; i <= 12; i++)
            {
                series.Points.AddXY(i, studentDAL.CountStudentsByMonth(i));
            }

            // Thêm Series vào Chart
            chartStatis.Series.Add(series);

            // Đặt tên cho trục X và Y
            chartStatis.ChartAreas[0].AxisX.Title = "Tháng";
            chartStatis.ChartAreas[0].AxisY.Title = "Số lượng sinh viên";
        }

        private void chartStatis_Click(object sender, EventArgs e)
        {

        }
    }
}
