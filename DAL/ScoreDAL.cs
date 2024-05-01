using DTO;
using StudentManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ScoreDAL
    {
        private string connectString = SharedConnectString.ConnectString;

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }

        public DataTable GetScoreList(string studentID = null)
        {
            DataTable dataTable = new DataTable();

            try
            {
                // Tạo câu truy vấn cơ sở
                string query = "SELECT * FROM Score";

                // Thêm điều kiện lọc theo studentID nếu được cung cấp
                if (!string.IsNullOrEmpty(studentID))
                {
                    query += $" WHERE studentID = '{studentID}'";
                }

                using (SqlConnection connection = Connection)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetScoreList:{ex.Message}]");
                throw;
            }

            return dataTable;
        }


        public DataTable GetStudentScoreCourseList()
        {
            SqlConnection connection = Connection;
            DataTable dataTable = new DataTable();

            try
            {
                string query = "select Student.studentID, firstName, lastName, Course.courseID, label, studentScore, Score.Semester " +
                    "from Score " +
                    "inner join Student on Score.studentID = Student.studentID " +
                    "inner join Course on Score.courseID = Course.courseID ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetStudentScoreCourseList:{ex.Message}]");
                throw;
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }


        public DataTable GetResult()
        {
            // Create a DataTable to store the result
            DataTable resultTable = new DataTable();

            // SQL query to retrieve data
            string query = @"SELECT s.studentID, s.firstName, s.lastName, c.label, sc.studentScore, sc.semester
                    FROM Score sc
                    INNER JOIN Student s ON sc.studentID = s.studentID
                    INNER JOIN Course c ON sc.courseID = c.courseID";

            try
            {
                // Create a SqlConnection using the provided Connection property
                using (SqlConnection connection = Connection)
                {
                    // Create a SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SqlDataAdapter to fetch data from database
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable with data from the query
                            adapter.Fill(resultTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetResult: {ex.Message}]");
                throw;
            }

            // Return the filled DataTable
            return resultTable;
        }

        public bool StudentHaveScore(string studentID)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand checkingCmd = new SqlCommand("SELECT * FROM Score WHERE studentID = @studentID", connection);
                checkingCmd.Parameters.AddWithValue("@studentID", studentID);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = checkingCmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[StudentHaveScore:{ex.Message}]");
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public bool HaveScore(string studentID, string courseID, int semester)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand checkingCmd = new SqlCommand("SELECT * FROM Score WHERE studentID = @studentID and courseID = @courseID and semester = @semester ", connection);
                checkingCmd.Parameters.AddWithValue("@studentID", studentID);
                checkingCmd.Parameters.AddWithValue("@courseID", courseID);
                checkingCmd.Parameters.AddWithValue("@semester", semester);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = checkingCmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 1) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HaveScore:{ex.Message}]");
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public void AddScore(Score score)
        {
            try
            {

                using (SqlConnection conn = Connection)
                {
                    string query = "INSERT INTO Score (studentID, courseID, semester, studentScore, description) VALUES (@StudentId, @CourseId, @Semester, @StudentScore, @Description)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", score.StudentId);
                        cmd.Parameters.AddWithValue("@CourseId", score.CourseId);
                        cmd.Parameters.AddWithValue("@Semester", score.Semester);
                        cmd.Parameters.AddWithValue("@StudentScore", score.StudentScore);
                        cmd.Parameters.AddWithValue("@Description", score.Description);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddScore:{ex.Message}]");
                throw;
            }
        }

        public void EditScore(Score score)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    string query = "UPDATE Score SET studentScore = @StudentScore, description = @Description WHERE studentID = @StudentId AND courseID = @CourseId AND semester = @Semester";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", score.StudentId);
                        cmd.Parameters.AddWithValue("@CourseId", score.CourseId);
                        cmd.Parameters.AddWithValue("@Semester", score.Semester);
                        cmd.Parameters.AddWithValue("@StudentScore", score.StudentScore);
                        cmd.Parameters.AddWithValue("@Description", score.Description);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EditScore:{ex.Message}]");
                throw;
            }

        }

        public int RemoveScore(string studentId, string courseId, int semester)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    string query = "DELETE FROM Score WHERE studentID = @StudentId AND courseID = @CourseId AND semester = @Semester ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        cmd.Parameters.AddWithValue("@CourseId", courseId);
                        cmd.Parameters.AddWithValue("@Semester", semester);
                        conn.Open();
                        int n = cmd.ExecuteNonQuery();
                        return n;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RemoveScore:{ex.Message}]");
                throw;
            }
        }

        public DataTable AvgScore(string studentID = null)
        {
            DataTable resultTable = new DataTable();
            try
            {
                using (SqlConnection conn = Connection)
                {
                    // Tạo câu truy vấn cơ sở dựa trên có hoặc không có điều kiện studentID
                    string query = "SELECT s.studentID, s.firstName, s.lastName, c.label AS CourseName, AVG(sc.studentScore) AS AverageScore " +
                                   "FROM Score sc " +
                                   "INNER JOIN Course c ON sc.courseID = c.courseID " +
                                   "INNER JOIN Student s ON sc.studentID = s.studentID ";

                    // Nếu studentID được cung cấp, thêm điều kiện WHERE vào câu truy vấn
                    if (!string.IsNullOrEmpty(studentID))
                    {
                        query += $"WHERE s.studentID = '{studentID}' ";
                    }

                    query += "GROUP BY s.studentID, s.firstName, s.lastName, c.label";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(resultTable);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AvgScore:{ex.Message}]");
                throw;
            }
            return resultTable;
        }


        public double GetPassPercentage(string studentID = null)
        {
            try
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();

                    // Query to get the total number of students
                    string totalScoresQuery = "SELECT COUNT(*) FROM Score WHERE 1 = 1";
                    // Add condition to filter by studentID if provided
                    if (!string.IsNullOrEmpty(studentID))
                    {
                        totalScoresQuery += $" AND studentID = '{studentID}'";
                    }

                    SqlCommand totalCmd = new SqlCommand(totalScoresQuery, conn);
                    int totalScores = (int)totalCmd.ExecuteScalar();

                    // Query to get the number of students with score >= 5
                    string passScoresQuery = "SELECT COUNT(*) FROM Score WHERE studentScore >= 5";

                    // Add condition to filter by studentID if provided
                    if (!string.IsNullOrEmpty(studentID))
                    {
                        passScoresQuery += $" AND studentID = '{studentID}'";
                    }

                    SqlCommand passCmd = new SqlCommand(passScoresQuery, conn);
                    int passScores = (int)passCmd.ExecuteScalar();

                    // Calculate and return the pass percentage
                    double passPercentage = ((double)passScores / totalScores) * 100;

                    return passPercentage;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetPassPercentage:{ex.Message}]");
                throw;
            }
        }



    }

}
