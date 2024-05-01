using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DAL;
using StudentManager.StudentForms;

namespace StudentManager
{
    public partial class FrmCourseStudentList : Form
    {
        private string courseID = null;
        public FrmCourseStudentList(string courseID)
        {
            InitializeComponent();
            this.courseID = courseID;
            txtCourseName.Text = courseID;
        }

        private void FrmCourseStudentList_Load(object sender, EventArgs e)
        {
            try
            {
                StudentCourseRegistrationDAL studentCourseRegistrationDAL = new StudentCourseRegistrationDAL();
                dtgvCourseStudentList.DataSource = studentCourseRegistrationDAL.GetRegistrationFromCourseID(courseID);
                dtgvCourseStudentList.Columns["studentID"].HeaderText = "MSSV";
                dtgvCourseStudentList.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
                dtgvCourseStudentList.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
                dtgvCourseStudentList.Columns["phoneNumber"].HeaderText = "SĐT";
                dtgvCourseStudentList.Columns["birthday"].HeaderText = "Ngày sinh"; // Đổi tên cột birthday
                dtgvCourseStudentList.Columns["gender"].HeaderText = "Giới tính";
                dtgvCourseStudentList.Columns["address"].HeaderText = "Địa chỉ";
                dtgvCourseStudentList.Columns["image"].HeaderText = "Ảnh";
                dtgvCourseStudentList.Columns["courseID"].HeaderText = "Mã môn"; // Đổi tên cột birthday
                dtgvCourseStudentList.Columns["semester"].HeaderText = "Học kỳ";
                dtgvCourseStudentList.Columns["label"].HeaderText = "Tên môn";
                dtgvCourseStudentList.Columns["period"].HeaderText = "Khoảng";
                dtgvCourseStudentList.Columns["description"].HeaderText = "Mô tả";

                ((DataGridViewImageColumn)dtgvCourseStudentList.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

                cbSemester.Items.AddRange(new string[] { "1", "2", "3"});
                cbSemester.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"FrmCourseStudentList_Load:{ex.Message}");
            }
        }
        


        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Creating a new Excel application
                    var excelApp = new Excel.Application();

                    // Adding a new workbook
                    var workbook = excelApp.Workbooks.Add(Type.Missing);
                    var worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                    // Adding column names
                    for (int i = 1; i < dtgvCourseStudentList.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dtgvCourseStudentList.Columns[i - 1].HeaderText;
                    }

                    // Adding rows
                    for (int i = 0; i < dtgvCourseStudentList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtgvCourseStudentList.Columns.Count; j++)
                        {
                            if (dtgvCourseStudentList.Columns[j].Name == "phoneNumber")
                            {
                                // Format cell as text before writing the phone number
                                ((Excel.Range)worksheet.Cells[i + 2, j + 1]).NumberFormat = "@";
                            }
                            else if (dtgvCourseStudentList.Columns[j].Name == "birthday")
                            {
                                // Format cell as date before writing the date
                                ((Excel.Range)worksheet.Cells[i + 2, j + 1]).NumberFormat = "mm/dd/yyyy";
                            }
                            else if (dtgvCourseStudentList.Columns[j].Name == "image")
                            {
                                // Skip the image column
                                continue;
                            }

                            worksheet.Cells[i + 2, j + 1] = dtgvCourseStudentList.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // Saving the workbook and closing the Excel application
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnPrint_Click:{ex.Message}");
            }
            

            /*
            try
            {
                BindingSource bs = dtgvCourseStudentList.DataSource as BindingSource;
                DataTable dt = bs.DataSource as DataTable;
                FrmSharedPrinter frmSharedPrinter = new FrmSharedPrinter(dt, "StudentCourseRegistration");
                frmSharedPrinter.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnPrint_Click:{ex.Message}");
            }
            */


        }

        

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dtgvCourseStudentList.DataSource;
            dtgvCourseStudentList.DataSource = bs;
            bs.Filter = "Semester = '" + cbSemester.SelectedItem.ToString() + "'";
        }
    }
}
