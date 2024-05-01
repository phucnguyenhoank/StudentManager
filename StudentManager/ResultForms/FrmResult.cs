using DAL;
using StudentManager.StudentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FrmResult : Form
    {
        private DataTable originalTable1 = null;
        private DataTable originalTable2 = null;

        public FrmResult()
        {
            InitializeComponent();
        }

        public DataTable CreateNewTable(DataTable resultTable)
        {
            // Create a new DataTable
            DataTable newTable = new DataTable();

            // Add "StudentID", "FirstName", "LastName" columns
            newTable.Columns.Add("StudentID", typeof(string));
            newTable.Columns.Add("FirstName", typeof(string));
            newTable.Columns.Add("LastName", typeof(string));

            // Add course columns based on distinct courses in resultTable
            var distinctCourses = resultTable.AsEnumerable()
                .Select(row => row.Field<string>("label"))
                .Distinct();
            foreach (var course in distinctCourses)
            {
                newTable.Columns.Add(course, typeof(double));
            }

            // Add "AvgScore" and "Rank" columns
            newTable.Columns.Add("AvgScore", typeof(double));
            newTable.Columns.Add("Rank", typeof(int));

            // Fill the newTable with data from resultTable
            foreach (var studentId in resultTable.AsEnumerable().Select(row => row.Field<string>("studentID")).Distinct())
            {
                DataRow newRow = newTable.NewRow();
                newRow["StudentID"] = studentId;
                newRow["FirstName"] = resultTable.AsEnumerable().First(row => row.Field<string>("studentID") == studentId)["firstName"];
                newRow["LastName"] = resultTable.AsEnumerable().First(row => row.Field<string>("studentID") == studentId)["lastName"];

                var studentScores = resultTable.AsEnumerable().Where(row => row.Field<string>("studentID") == studentId);
                foreach (var score in studentScores)
                {
                    double studentScore;
                    if (double.TryParse(score["studentScore"].ToString(), out studentScore))
                    {
                        newRow[score.Field<string>("label")] = studentScore;
                    }

                }

                newRow["AvgScore"] = studentScores.Where(row => !row.IsNull("studentScore")).Average(row => Convert.ToDouble(row["studentScore"]));


                newTable.Rows.Add(newRow);
            }

            // Calculate rank based on AvgScore
            newTable.DefaultView.Sort = "AvgScore DESC";
            newTable = newTable.DefaultView.ToTable();
            for (int i = 0; i < newTable.Rows.Count; i++)
            {
                newTable.Rows[i]["Rank"] = i + 1;
            }

            return newTable;
        }

        public (string firstName, string lastName) GetStudentName(DataTable resultTable, string studentID)
        {
            // Query the DataTable using LINQ to find the row with the specified studentID
            var query = from row in resultTable.AsEnumerable()
                        where row.Field<string>("studentID") == studentID
                        select new
                        {
                            FirstName = row.Field<string>("firstName"),
                            LastName = row.Field<string>("lastName")
                        };

            // Execute the query and retrieve the result
            var result = query.FirstOrDefault();

            // Check if the result is null (studentID not found in the DataTable)
            if (result == null)
            {
                throw new Exception("Student ID not found in the result table.");
            }

            // Return the firstName and lastName
            return (result.FirstName, result.LastName);
        }


        private void FrmResult_Load(object sender, EventArgs e)
        {
            ScoreDAL scoreDAL = new ScoreDAL();
            originalTable1 = scoreDAL.GetResult();
            originalTable2 = CreateNewTable(originalTable1);
            dtgvResult.DataSource = originalTable2;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {

            // Create a new DataTable to store the search result
            DataTable searchResultTable = new DataTable();

            // Copy the structure of the original DataTable
            foreach (DataColumn column in originalTable2.Columns)
            {
                searchResultTable.Columns.Add(column.ColumnName, column.DataType);
            }

            // Find the rows that match the search string
            foreach (DataRow row in originalTable2.Rows)
            {
                if (row["FirstName"].ToString().Contains(txtSearch.Text) || row["StudentID"].ToString().Contains(txtSearch.Text))
                {
                    searchResultTable.ImportRow(row);
                }
            }

            dtgvResult.DataSource = searchResultTable;

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ScoreDAL scoreDAL = new ScoreDAL();
                if (string.IsNullOrEmpty(txtStudentID.Text))
                {
                    MessageBox.Show("Student ID text box is empty", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!scoreDAL.StudentHaveScore(txtStudentID.Text))
                {
                    MessageBox.Show("Student ID have not had any score yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    (string firstName, string lastName) = GetStudentName(originalTable1, txtStudentID.Text);

                    
                    FrmSharedPrinter frmSharedPrinter = new FrmSharedPrinter(scoreDAL.GetScoreList(txtStudentID.Text), "ScoreForStudent", txtStudentID.Text, lastName + " " + firstName);
                    frmSharedPrinter.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không mong đợi đã xảy ra: {ex.Message}");
            }
            
            
            
        }
    }
}
