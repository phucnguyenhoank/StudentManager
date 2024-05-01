using DAL;
using Microsoft.ReportingServices.Diagnostics.Internal;
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

namespace StudentManager
{
    public partial class FrmStatisticResult : Form
    {
        private DataTable resultTable = null;

        public FrmStatisticResult()
        {
            InitializeComponent();
            ScoreDAL scoreDAL = new ScoreDAL();
            resultTable = scoreDAL.GetResult();
        }

        private DataTable SelectColumns(DataTable dt, params string[] columnNames)
        {
            // Create a new DataTable to store selected columns
            DataTable selectedColumnsTable = new DataTable();

            // Add selected columns to the new DataTable
            foreach (string columnName in columnNames)
            {
                selectedColumnsTable.Columns.Add(columnName, dt.Columns[columnName].DataType);
            }

            // Copy data from original DataTable to the new DataTable
            foreach (DataRow row in dt.Rows)
            {
                DataRow newRow = selectedColumnsTable.NewRow();
                foreach (string columnName in columnNames)
                {
                    newRow[columnName] = row[columnName];
                }
                selectedColumnsTable.Rows.Add(newRow);
            }

            return selectedColumnsTable;
        }


        private DataTable FilterDataTable(DataTable dt, string filterExpression)
        {
            // Create a DataView from the original DataTable
            DataView dv = new DataView(dt);

            // Apply the filter expression
            dv.RowFilter = filterExpression;

            // Return the filtered data as a new DataTable
            return dv.ToTable();
        }


        private DataTable GroupData(DataTable dt, string[] groupByColumns, string aggregateColumn)
        {
            // Create a DataView from the original DataTable
            DataView dv = new DataView(dt);

            // Set the Sort property of the DataView based on groupByColumns
            string sortExpression = string.Join(",", groupByColumns);
            dv.Sort = sortExpression;

            // Create a new DataTable to store the grouped data
            DataTable groupedTable = new DataTable();

            // Add columns to the grouped DataTable
            foreach (string colName in groupByColumns)
            {
                groupedTable.Columns.Add(colName, dt.Columns[colName].DataType);
            }

            // Add a column for the aggregated value
            groupedTable.Columns.Add("AggregateValue", dt.Columns[aggregateColumn].DataType);

            // Group the DataView by the specified columns and calculate the aggregate value
            foreach (DataRowView drv in dv)
            {
                // Get the group key
                object[] groupKey = groupByColumns.Select(col => drv[col]).ToArray();

                // Check if a group with the same key already exists in the grouped DataTable
                DataRow existingRow = groupedTable.Rows.Find(groupKey);
                if (existingRow != null)
                {
                    // Aggregate the value
                    existingRow["AggregateValue"] = Convert.ToDouble(existingRow["AggregateValue"]) + Convert.ToDouble(drv[aggregateColumn]);
                }
                else
                {
                    // Add a new row for the group
                    DataRow newRow = groupedTable.NewRow();
                    newRow.ItemArray = groupKey.Concat(new object[] { drv[aggregateColumn] }).ToArray();
                    groupedTable.Rows.Add(newRow);
                }
            }

            return groupedTable;
        }



        private void LoadChart(string studentID = null)
        {
            try
            {
                // Get the average score data
                ScoreDAL scoreDAL = new ScoreDAL();
                DataTable dt = null;
                if (cbStudentID.SelectedItem.ToString() == "All students")
                {
                    dt = scoreDAL.AvgScore();
                    lblPassPercent.Text = "Total pass score: " + scoreDAL.GetPassPercentage().ToString() + "%";

                }
                else
                {
                    dt = scoreDAL.AvgScore(cbStudentID.SelectedItem.ToString());
                    lblPassPercent.Text = "Total pass score: " + scoreDAL.GetPassPercentage(cbStudentID.SelectedItem.ToString()).ToString() + "%";
                }

                // Sort the DataTable by "CourseName" column in descending order
                DataView dv = dt.DefaultView;
                dv.Sort = "AverageScore ASC"; // Sắp xếp theo tên khóa học giảm dần
                DataTable sortedDT = dv.ToTable();

                // Clear the chart
                chartScoreResult.Series.Clear();

                // Create a new series
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "AvgScore",
                    Color = System.Drawing.Color.Blue,
                    IsVisibleInLegend = false,
                    IsXValueIndexed = true,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };

                // Add data to the series
                foreach (DataRow row in sortedDT.Rows)
                {
                    series.Points.AddXY(row["CourseName"].ToString(), row["AverageScore"]);
                }

                // Add the series to the chart
                chartScoreResult.Series.Add(series);

                // Set the chart's title
                chartScoreResult.Titles.Clear();
                chartScoreResult.Titles.Add("Average Score by Course");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"LoadChart:{ex.Message}");
            }
        }


        public List<string> ConvertColumnToStringList(DataTable dataTable, string columnName)
        {
            List<string> columnValues = new List<string>();

            // Kiểm tra xem cột có tồn tại trong DataTable không
            if (dataTable.Columns.Contains(columnName))
            {
                // Lặp qua từng dòng của DataTable và thêm giá trị của cột vào danh sách
                foreach (DataRow row in dataTable.Rows)
                {
                    string value = row[columnName].ToString(); // Chuyển giá trị thành kiểu string
                    columnValues.Add(value);
                }
            }

            return columnValues;
        }


        public List<string> ConvertColumnToUniqueStringList(DataTable dataTable, string columnName)
        {
            HashSet<string> uniqueValues = new HashSet<string>(); // Sử dụng HashSet để lưu trữ các giá trị duy nhất

            // Kiểm tra xem cột có tồn tại trong DataTable không
            if (dataTable.Columns.Contains(columnName))
            {
                // Lặp qua từng dòng của DataTable và thêm giá trị của cột vào HashSet
                foreach (DataRow row in dataTable.Rows)
                {
                    string value = row[columnName].ToString(); // Chuyển giá trị thành kiểu string
                    uniqueValues.Add(value);
                }
            }

            // Chuyển HashSet thành List và trả về
            return new List<string>(uniqueValues);
        }


        private void LoadCB()
        {

            cbStudentID.Items.Add("All students");
            cbStudentID.Items.AddRange(ConvertColumnToUniqueStringList(resultTable, "studentID").ToArray());
            cbStudentID.SelectedIndex = 0;

        }


        private void FrmStatisticResult_Load(object sender, EventArgs e)
        {
            LoadCB();
            LoadChart();
            
            ScoreDAL scoreDAL = new ScoreDAL();
            lblPassPercent.Text = "Total pass score: " + scoreDAL.GetPassPercentage().ToString() + "%";
        }

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
