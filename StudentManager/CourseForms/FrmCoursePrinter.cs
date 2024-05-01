using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace StudentManager
{
    public partial class FrmCoursePrinter : Form
    {
        public FrmCoursePrinter()
        {
            InitializeComponent();
        }

        private void FrmPrintCourse_Load(object sender, EventArgs e)
        {
            CourseDAL courseDAL = new CourseDAL();

            this.rpvCouseList.LocalReport.ReportEmbeddedResource = "StudentManager.RPCourseList.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "StudentManagerDS"; // Tên của ReportDataSource, phải khớp với tên đã đặt trong file .rdlc
            rds.Value = courseDAL.GetCourseList(); // Đối tượng DataTable chứa dữ liệu cần in

            this.rpvCouseList.LocalReport.DataSources.Clear(); // Xóa các nguồn dữ liệu hiện có
            this.rpvCouseList.LocalReport.DataSources.Add(rds); // Thêm ReportDataSource mới vào danh sách

            this.rpvCouseList.RefreshReport(); // Làm mới và hiển thị báo cáo
        }
    }
}
