using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using StudentManager.StudentForms;

namespace StudentManager
{
    public partial class FrmPrintStudent : Form
    {
        public FrmPrintStudent()
        {
            InitializeComponent();
        }

        private void LoadPrintedData()
        {
            try
            {
                StudentDAL studentDAL = new StudentDAL();
                System.Data.DataTable dataTableStudents = studentDAL.GetStudentList();
                dtgvPrintedStudentList.DataSource = dataTableStudents;
                dtgvPrintedStudentList.Columns["studentID"].HeaderText = "MSSV";
                dtgvPrintedStudentList.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
                dtgvPrintedStudentList.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
                dtgvPrintedStudentList.Columns["phoneNumber"].HeaderText = "SĐT";
                dtgvPrintedStudentList.Columns["birthday"].HeaderText = "Ngày sinh"; // Đổi tên cột birthday
                dtgvPrintedStudentList.Columns["gender"].HeaderText = "Giới tính";
                dtgvPrintedStudentList.Columns["address"].HeaderText = "Địa chỉ";
                dtgvPrintedStudentList.Columns["image"].HeaderText = "Ảnh";

                // Đổi cách hiển thị
                dtgvPrintedStudentList.Columns["birthday"].DefaultCellStyle.Format = "MM/dd/yyyy";
                ((DataGridViewImageColumn)dtgvPrintedStudentList.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static DataTable ToStudentDataTableFromDTGV(DataGridView dtgv)
        {
            DataTable dt = dtgv.DataSource as DataTable;
            return dt;
        }



        private void FrmPrintStudent_Load(object sender, EventArgs e)
        {
            LoadPrintedData();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string filterConditionString = "";
                if (rbMale.Checked)
                {
                    filterConditionString += "gender = 'Male'";
                }
                else if (rbFemale.Checked)
                {
                    filterConditionString += "gender = 'Female'";
                }

                if (rbYes.Checked)
                {
                    DateTime startBirthday = dtpStartBirthday.Value;
                    DateTime endBirthday = dtpEndBirthday.Value;

                    // Add the birthday condition to the filter
                    if (!string.IsNullOrEmpty(filterConditionString))
                    {
                        filterConditionString += " AND ";
                    }
                    filterConditionString += $"birthday BETWEEN '{startBirthday:yyyy-MM-dd}' AND '{endBirthday:yyyy-MM-dd}'";
                }

                StudentDAL studentDAL = new StudentDAL();
                dtgvPrintedStudentList.DataSource = studentDAL.GetStudentInCondition(filterConditionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnCheck_Click:{ex.Message}");
            }

        }


        private void btnToPrinter_Click(object sender, EventArgs e)
        {

            FrmSharedPrinter frmStudentPrinter = new FrmSharedPrinter(ToStudentDataTableFromDTGV(this.dtgvPrintedStudentList), "Student");
            frmStudentPrinter.ShowDialog();
        }


    }
}
