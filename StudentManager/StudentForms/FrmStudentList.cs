using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Xceed.Document.NET;
using Xceed.Words.NET;
using DAL;
using Microsoft.ReportingServices.Diagnostics.Internal;
using StudentManager.StudentForms;


namespace StudentManager
{
    public partial class FrmStudentList : Form
    {
        frmWorkLoadingStudentList frmWorkLoading = null;
        public FrmStudentList()
        {
            InitializeComponent();
        }

        private void btnResetStudentList_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDAL studentDAL = new StudentDAL();
                System.Data.DataTable dataTableStudents = studentDAL.GetStudentList();
                dataGridViewStudentList.DataSource = dataTableStudents;
                dataGridViewStudentList.Columns["studentID"].HeaderText = "MSSV";
                dataGridViewStudentList.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
                dataGridViewStudentList.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
                dataGridViewStudentList.Columns["phoneNumber"].HeaderText = "SĐT";
                dataGridViewStudentList.Columns["birthday"].HeaderText = "Ngày sinh"; // Đổi tên cột birthday
                dataGridViewStudentList.Columns["gender"].HeaderText = "Giới tính";
                dataGridViewStudentList.Columns["address"].HeaderText = "Địa chỉ";
                dataGridViewStudentList.Columns["image"].HeaderText = "Ảnh";

                // Đổi cách hiển thị
                dataGridViewStudentList.Columns["birthday"].DefaultCellStyle.Format = "MM/dd/yyyy";
                ((DataGridViewImageColumn)dataGridViewStudentList.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            }
            catch (Exception ex)
            {
                MessageBox.Show("btnResetStudentList_Click: " + ex.Message);
            }
        }

        private void dataGirdViewStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có phải double click vào header cell hay không
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    // Lấy giá trị của cell được double click
                    object cellValue = dataGridViewStudentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    // nếu nhấn vào cột id
                    if (e.ColumnIndex == 0)
                    {
                        FrmEditRemoveStudent myFrmEditStudent = new FrmEditRemoveStudent();

                        System.Data.DataTable dataTable = (new StudentDAL()).GetStudentDataTableByID(cellValue.ToString());

                        DataRow row = dataTable.Rows[0];
                        myFrmEditStudent.TxtEditStudentID.Text = row.Field<string>("studentID");
                        myFrmEditStudent.TxtEditStudentFirstName.Text = row.Field<string>("firstName");
                        myFrmEditStudent.TxtEditStudentLastName.Text = row.Field<string>("lastName");
                        myFrmEditStudent.TxtEditStudentPhoneNumber.Text = row.Field<string>("phoneNumber");
                        myFrmEditStudent.DtpEditStudentBirthday.Value = row.Field<DateTime>("birthday");
                        myFrmEditStudent.RadioBtnEditStudentGender.Checked = (row.Field<string>("gender") == "Male") ? true : false;
                        myFrmEditStudent.TxtEditStudentAddress.Text = row.Field<string>("address");

                        MemoryStream ms = new MemoryStream(row.Field<byte[]>("image"));
                        myFrmEditStudent.PicboxEditStudentImage.Image = System.Drawing.Image.FromStream(ms);
                        myFrmEditStudent.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"dataGirdViewStudentList_CellDoubleClick:{ex.Message}");
            }
            
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            btnResetStudentList_Click(sender, e);
        }

        public void ApplyNewDataTable(System.Data.DataTable dataTable)
        {
            try
            {
                dataGridViewStudentList.DataSource = dataTable;
                dataGridViewStudentList.Columns["studentID"].HeaderText = "MSSV";
                dataGridViewStudentList.Columns["firstName"].HeaderText = "Tên"; // Đổi tên cột firstName
                dataGridViewStudentList.Columns["lastName"].HeaderText = "Họ"; // Đổi tên cột lastName
                dataGridViewStudentList.Columns["phoneNumber"].HeaderText = "SĐT";
                dataGridViewStudentList.Columns["birthday"].HeaderText = "Ngày sinh"; // Đổi tên cột birthday
                dataGridViewStudentList.Columns["gender"].HeaderText = "Giới tính";
                dataGridViewStudentList.Columns["address"].HeaderText = "Địa chỉ";
                dataGridViewStudentList.Columns["image"].HeaderText = "Ảnh";

                // Đổi cách hiển thị
                dataGridViewStudentList.Columns["birthday"].DefaultCellStyle.Format = "MM/dd/yyyy";
                ((DataGridViewImageColumn)dataGridViewStudentList.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ApplyNewDataTable:{ex.Message}");
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {

                FrmStudentFilter tempFrmStudentFilter = new FrmStudentFilter();

                if (tempFrmStudentFilter.ShowDialog() == DialogResult.OK)
                {
                    ApplyNewDataTable(tempFrmStudentFilter.FilteredData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnFilter_Click:{ex.Message}");
            }
        }

        private void ExportToWord(System.Data.DataTable dataTable, string filePath)
        {
            try
            {
                // Create a new Word document
                using (DocX doc = DocX.Create(filePath))
                {
                    // Add a table with the same number of columns as the DataTable
                    Table table = doc.AddTable(dataTable.Rows.Count + 1, dataTable.Columns.Count);

                    // Populate the first row with column names from the DataTable
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        table.Rows[0].Cells[i].Paragraphs.First().Append(dataTable.Columns[i].ColumnName);
                    }

                    // Populate the remaining rows with data from the DataTable
                    for (int rowIndex = 0; rowIndex < dataTable.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < dataTable.Columns.Count; colIndex++)
                        {
                            table.Rows[rowIndex + 1].Cells[colIndex].Paragraphs.First().Append(dataTable.Rows[rowIndex][colIndex].ToString());
                        }
                    }

                    // Add the table to the document
                    doc.InsertTable(table);

                    // Save the document
                    doc.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ExportToWord:{ex.Message}");
            }
            
        }

        private bool ContainsNumeric(string input)
        {
            return input.Any(char.IsDigit);
        }

        public int importStudentListExcel(object sender, EventArgs e, OpenFileDialog openFileDialog)
        {
            int insertedRowNumber = 0;
            try
            {
                // lọc phải báo
                // danh sách các các môn student đã đăng ký
                // Initialize Excel application
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                Worksheet worksheet = workbook.ActiveSheet;

                // Get the used range of the worksheet
                Range range = worksheet.UsedRange;

                // Set the maximum value of the ProgressBar
                // frmWorkLoading.progressBarStudentListLoading.Maximum = range.Rows.Count;

                // Create DataTable to hold Excel data
                System.Data.DataTable dt = new System.Data.DataTable();

                for (int row = 1; row <= range.Rows.Count; row++)
                {
                    DataRow dr = dt.NewRow();
                    for (int col = 1; col <= range.Columns.Count; col++)
                    {
                        Range cell = range.Cells[row, col] as Range;
                        if (cell != null && cell.Value2 != null)
                        {
                            string cellValue = cell.Value2.ToString();
                            if (row == 1)
                            {
                                // Add columns from the first row
                                dt.Columns.Add(cellValue);
                            }
                            else
                            {
                                // Add data rows
                                dr[col - 1] = cellValue;
                            }
                        }
                        else if (row == 1)
                        {
                            // Add empty column for null or empty cell in the first row
                            dt.Columns.Add("");
                        }
                    }
                    if (row != 1)
                    {
                        // Calculate email and add to the row
                        string email = dr[1].ToString() + "@student.hcmute.edu.vn"; // Assuming the second column contains MaSV
                        dr["Email"] = email;
                        dt.Rows.Add(dr);
                    }

                    // REPORT
                    frmWorkLoading.backgroundWorkerStudentList.ReportProgress(row);
                }

                StudentDAL studentDAL = new StudentDAL();

                System.Data.DataTable existingData = studentDAL.GetStudentList(); // (System.Data.DataTable)dataGirdViewStudentList.DataSource;
                List<int> wrongRows = new List<int>(); // Create a list to store indices of wrong rows


                int rowIndex = 1; // Initialize row index

                foreach (DataRow row in dt.Rows)
                {
                    if (!ContainsNumeric(row["Họ"].ToString()) && !ContainsNumeric(row["Tên"].ToString()) && !studentDAL.HaveStudent((string)row["Mã SV"]))
                    {
                        DataRow newRow = existingData.NewRow();

                        newRow[0] = row["Mã SV"];
                        newRow[1] = row["Tên"];
                        newRow[2] = row["Họ"];

                        DateTime ngaySinh;
                        if (DateTime.TryParseExact(row["Ngày sinh"].ToString(), "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                        {
                            newRow[4] = ngaySinh;
                        }
                        else
                        {
                            newRow[4] = DBNull.Value;
                        }

                        existingData.Rows.Add(newRow);
                        insertedRowNumber += 1;
                    }
                    else
                    {
                        wrongRows.Add(rowIndex); // Add the index of the wrong row to the list
                    }

                    rowIndex++; // Increment row index for the next iteration
                }

                // After the loop, show the wrong rows
                StringBuilder errorMessage = new StringBuilder();

                foreach (int wrongRowIndex in wrongRows)
                {
                    errorMessage.AppendLine($"Dữ liệu tại dòng {wrongRowIndex} không hợp lệ: Họ hoặc Tên chứa số hoặc Mã Sinh Viên đã tồn tại.");
                }

                if (errorMessage.Length > 0)
                {
                    MessageBox.Show(errorMessage.ToString());
                }

                studentDAL.SaveStudentListImportedDataTable(existingData);

                // Release Excel resources
                workbook.Close(false);
                excelApp.Quit();
                releaseObject(worksheet);
                releaseObject(workbook);
                releaseObject(excelApp);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"importStudentListExcel:{ex.Message}");
            }
            return insertedRowNumber;
        }

        public void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    frmWorkLoading = new frmWorkLoadingStudentList(this, openFileDialog);
                    frmWorkLoading.ShowDialog();
                    // reset data grid view
                    btnResetStudentList_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"btnImport_Click:{ex.Message}");
            }
        }

        private void ExportToExcel(System.Data.DataTable dataTable, string filePath)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Sheets[1];

            // Ghi tên cột vào hàng đầu tiên
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
            }

            // Ghi dữ liệu từ DataTable vào Excel, bắt đầu từ hàng thứ hai
            int rowCount = 2;
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[rowCount, i + 1] = row[i].ToString();
                }
                rowCount++;
            }

            // Lưu workbook vào đường dẫn đã chỉ định
            workbook.SaveAs(filePath);

            // Đóng workbook và đóng ứng dụng Excel
            workbook.Close();
            excelApp.Quit();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void SaveImportedData(System.Data.DataTable dt)
        {

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                // Khởi tạo SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn được chọn bởi người dùng từ SaveFileDialog
                    string filePath = saveFileDialog.FileName;

                    // Gọi phương thức ExportToExcel với DataTable bạn muốn ghi và đường dẫn tập tin Excel
                    ExportToExcel((System.Data.DataTable)dataGridViewStudentList.DataSource, filePath);

                    MessageBox.Show("Dữ liệu đã được xuất thành công vào tập tin Excel!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"[btnExportToExcel_Click{ex.Message}]");
            }
            */


            try
            {

                FrmSharedPrinter frmSharedPrinter = new FrmSharedPrinter(dataGridViewStudentList.DataSource as System.Data.DataTable, "Student");
                frmSharedPrinter.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"[btnExportToExcel_Click:{ex.Message}]");
            }


        }


    }
}
