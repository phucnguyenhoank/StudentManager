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
    public class CourseDAL
    {
        
        private string connectString = SharedConnectString.ConnectString;

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }


        public bool HaveCourse(string courseID)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand checkingCmd = new SqlCommand("SELECT * FROM Course WHERE courseID = @courseID", connection);
                checkingCmd.Parameters.AddWithValue("@courseID", courseID);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = checkingCmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HaveCourse:{ex.Message}]");
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

        public bool AddCourse(Course course)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand insertCourseCmd = connection.CreateCommand();
                insertCourseCmd.CommandText = "INSERT INTO Course (courseID, label, period, description) " +
                    "VALUES (@courseID, @label, @period, @description)";
                insertCourseCmd.Parameters.AddWithValue("@courseID", course.CourseID);
                insertCourseCmd.Parameters.AddWithValue("@label", course.Label);
                insertCourseCmd.Parameters.AddWithValue("@period", course.Period);
                insertCourseCmd.Parameters.AddWithValue("@description", course.Description);

                if (insertCourseCmd.ExecuteNonQuery() == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddCourse:{ex.Message}]");
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

        public bool RemoveCourse(string courseId)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string deleteQuery = "DELETE " +
                    "FROM Course " +
                    "WHERE courseId = @courseId";

                SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@courseId", courseId);
                if (deleteCmd.ExecuteNonQuery() == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RemoveCourse:{ex.Message}]");
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

        public bool EditCourse(string courseId, Course newCourse)
        {
            try
            {
                string query = "UPDATE Course " +
                                "SET label = @label, period = @period, description = @description " +
                                "WHERE courseID = @courseID";

                using (SqlConnection connection = Connection)
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@label", newCourse.Label);
                        command.Parameters.AddWithValue("@period", newCourse.Period);
                        command.Parameters.AddWithValue("@description", newCourse.Description);
                        command.Parameters.AddWithValue("@courseID", courseId);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra số hàng bị ảnh hưởng để xác nhận việc cập nhật thành công
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EditCourse:{ex.Message}]");
                throw;
            }
        }


        public List<string> GetIdColumn()
        {
            List<string> dataList = new List<string>();
            SqlConnection connection = null;

            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT courseId FROM Course";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataList.Add(reader["courseId"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetIdColumn:{ex.Message}]");
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return dataList;
        }

        public DataTable GetCourseList()
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "SELECT * FROM Course";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetCourseList:{ex.Message}]");
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

        public DataTable GetCourseList(string studentID, int semester)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "select Course.courseID, Course.label " +
                    "from StudentCourseRegistration " +
                    "inner join Course on StudentCourseRegistration.courseID = Course.courseID " +
                    "where studentID = @studentID and semester = @semester";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentID", studentID);
                command.Parameters.AddWithValue("@semester", semester);


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetCourseList:{ex.Message}]");
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

        public DataTable GetCourseListByContactID(string contactID)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = @"SELECT Course.courseID, Course.label, Course.period, Course.description
                         FROM Teach
                         INNER JOIN Contact ON Teach.contactID = Contact.contactID
                         INNER JOIN Course ON Teach.courseID = Course.courseID
                         WHERE Teach.contactID = @contactID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@contactID", contactID);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetCourseListByTeachID: {ex.Message}]");
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



    }
}
