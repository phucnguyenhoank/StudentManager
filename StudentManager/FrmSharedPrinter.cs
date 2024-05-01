using Microsoft.Reporting.WinForms;
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
using System.IO;

namespace StudentManager.StudentForms
{
    
    public partial class FrmSharedPrinter : Form
    {
        private DataTable needToPrintDataTable = null;
        private string tableName;

        // chỉ cho ScoreForStudentList file
        private string studentID, studentName;

        public FrmSharedPrinter(DataTable needToPrintDataTable, string tableName, string studentID="", string studentName="")
        {
            InitializeComponent();
            this.needToPrintDataTable = needToPrintDataTable;
            this.tableName = tableName;
            this.studentID = studentID;
            this.studentName = studentName;

        }

        private void FrmStudentPrinter_Load(object sender, EventArgs e)
        {
            
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Go up directories
            DirectoryInfo directoryInfo = Directory.GetParent(projectDirectory);
            directoryInfo = Directory.GetParent(directoryInfo.FullName);
            directoryInfo = Directory.GetParent(directoryInfo.FullName);

            reportViewer1.LocalReport.ReportPath = $"{directoryInfo.FullName}\\RPPrinter\\{this.tableName}List.rdlc";

            // Truyền giá trị chuỗi vào Report Parameter
            if (tableName == "ScoreForStudent")
            {
                ReportParameter parameter = new ReportParameter("ReportParameterStudentID", studentID);
                this.reportViewer1.LocalReport.SetParameters(parameter);

                ReportParameter parameter2 = new ReportParameter("ReportParameterStudentFullName", studentName);
                this.reportViewer1.LocalReport.SetParameters(parameter2);
            }
            

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "ManagerStudentDS";

            reportDataSource.Value = this.needToPrintDataTable;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();

        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
    

}
