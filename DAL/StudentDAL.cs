using StudentManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{

    // the data base must have already created before

    public class StudentDAL
    {
        private string connectString = SharedConnectString.ConnectString;

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }

        public bool AddStudent(Student student)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string insertStudentQuery = "INSERT INTO Student " +
                        "VALUES " +
                        "(@studentID, @firstName, @lastName, @phoneNumber, @birthday, @gender, @address, @image)";

                SqlCommand insertStudentCmd = new SqlCommand(insertStudentQuery, connection);
                insertStudentCmd.Parameters.AddWithValue("@studentID", student.StudentID);
                insertStudentCmd.Parameters.AddWithValue("@firstName", student.FirstName);
                insertStudentCmd.Parameters.AddWithValue("@lastName", student.LastName);
                insertStudentCmd.Parameters.AddWithValue("@phoneNumber", student.PhoneNumber);
                insertStudentCmd.Parameters.AddWithValue("@birthday", student.Birthday);
                insertStudentCmd.Parameters.AddWithValue("@gender", student.Gender);
                insertStudentCmd.Parameters.AddWithValue("@address", student.Address);
                insertStudentCmd.Parameters.AddWithValue("@image", student.Image);

                if (insertStudentCmd.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddStudent:{ex.Message}]");
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

        public bool RemoveStudent(string studentId)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string removeStudentQuery = "DELETE FROM Student " +
                    "WHERE studentID = @studentID";
                SqlCommand removeStudentCmd = new SqlCommand(removeStudentQuery, connection);
                removeStudentCmd.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentId;
                if (removeStudentCmd.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RemoveStudent:{ex.Message}]");
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

        public bool HaveStudent(string studentID)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand checkingCmd = new SqlCommand("SELECT * FROM Student WHERE studentID = @studentID", connection);
                checkingCmd.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = checkingCmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 1) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HaveStudent:{ex.Message}]");
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

        public DataTable GetStudentDataTableByID(string studentID)
        {

            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "SELECT * FROM Student WHERE studentID = @studentID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add("@studentID", SqlDbType.VarChar).Value = studentID;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetStudentDataTableByID:{ex.Message}]");
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close(); // Đóng kết nối sau khi sử dụng xong
                }
            }

        }

        public DataTable GetStudentList()
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "SELECT * FROM Student";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetStudentList:{ex.Message}]");
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close(); // Đóng kết nối sau khi sử dụng xong
                }
            }
        }

        public DataTable GetStudentInCondition(string condition = null)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "SELECT * FROM Student";
                if (!string.IsNullOrEmpty(condition))
                {
                    query += $" WHERE {condition}";
                }

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetStudentInCondition:{ex.Message}]");
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

        public bool EditStudent(string studentID, Student newStudent)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                // Check if the student with given studentID exists
                if (HaveStudent(studentID))
                {
                    // Update the existing student record in the database
                    string updateStudentQuery = "UPDATE Student SET " +
                        "FirstName = @firstName, " +
                        "LastName = @lastName, " +
                        "PhoneNumber = @phoneNumber, " +
                        "Birthday = @birthday, " +
                        "Gender = @gender, " +
                        "Address = @address, " +
                        "Image = @image " +
                        "WHERE StudentID = @studentID";

                    SqlCommand updateStudentCmd = new SqlCommand(updateStudentQuery, connection);
                    updateStudentCmd.Parameters.AddWithValue("@firstName", newStudent.FirstName);
                    updateStudentCmd.Parameters.AddWithValue("@lastName", newStudent.LastName);
                    updateStudentCmd.Parameters.AddWithValue("@phoneNumber", newStudent.PhoneNumber);
                    updateStudentCmd.Parameters.AddWithValue("@birthday", newStudent.Birthday);
                    updateStudentCmd.Parameters.AddWithValue("@gender", newStudent.Gender);
                    updateStudentCmd.Parameters.AddWithValue("@address", newStudent.Address);
                    updateStudentCmd.Parameters.AddWithValue("@image", newStudent.Image);
                    updateStudentCmd.Parameters.AddWithValue("@studentID", studentID);

                    if (updateStudentCmd.ExecuteNonQuery() > 0)
                    {
                        // Update successful
                        return true;
                    }
                    else
                    {
                        // Update failed
                        return false;
                    }
                }
                else
                {
                    // Student with studentID not found
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EditStudent:{ex.Message}]");
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


        public string CreateStudentFilterQuery(string studentID, string firstStudentName, string lastStudentName, string phoneNumber, DateTime studentBirthday, string gender, string address)
        {
            string query = "SELECT * FROM Student WHERE 1 = 1";

            if (!string.IsNullOrEmpty(studentID))
            {
                query += $" AND studentID = '{studentID}'";
            }

            if (!string.IsNullOrEmpty(firstStudentName))
            {
                query += $" AND firstName = N'{firstStudentName}'";
            }

            if (!string.IsNullOrEmpty(lastStudentName))
            {
                query += $" AND lastName = N'{lastStudentName}'";
            }

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                query += $" AND phoneNumber = '{phoneNumber}'";
            }

            DateTime minDateTime = new DateTime(1753, 1, 1);
            if (studentBirthday != minDateTime)
            {
                query += $" AND birthday = @birthday";
            }

            if (!string.IsNullOrEmpty(gender))
            {
                query += $" AND gender = '{gender}'";
            }

            if (!string.IsNullOrEmpty(address))
            {
                query += $" AND address = @address";
            }

            return query;
        }

        public DataTable GetStudentFilterResult(string studentID, string firstStudentName, string lastStudentName, string phoneNumber, DateTime studentBirthday, string gender, string address)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = CreateStudentFilterQuery(studentID, firstStudentName, lastStudentName, phoneNumber, studentBirthday, gender, address);
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters for any DateTime values
                DateTime minDateTime = new DateTime(1753, 1, 1);
                if (studentBirthday != minDateTime)
                {
                    command.Parameters.AddWithValue("@birthday", studentBirthday);
                }
                if (!string.IsNullOrEmpty(address))
                {
                    command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetStudentFilterResult:{ex.Message}]");
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

        public void SaveStudentListImportedDataTable(DataTable importedDT)
        {
            // DeleteStudentList();
            foreach (DataRow row in importedDT.Rows)
            {
                string studentID = row.IsNull(0) ? string.Empty : (string)row[0];
                string firstName = row.IsNull(1) ? string.Empty : (string)row[1];
                string lastName = row.IsNull(2) ? string.Empty : (string)row[2];
                string phoneNumber = row.IsNull(3) ? string.Empty : (string)row[3];
                DateTime birthDay = row.IsNull(4) ? DateTime.MinValue : (DateTime)row[4];
                string gender = row.IsNull(5) ? string.Empty : (string)row[5];
                string address = row.IsNull(6) ? string.Empty : (string)row[6];

                byte[] imageData;
                if (row.IsNull(7))
                {
                    string defaultImagePath = "E:\\hello_csharp\\Day2_Again\\StudentManager\\anh_mac_dinh\\anh_mac_dinh2.jpg";
                    imageData = File.ReadAllBytes(defaultImagePath);
                }
                else
                {
                    imageData = (byte[])row[7];
                }

                Student st = new Student(studentID, firstName, lastName, phoneNumber, birthDay, gender, address, imageData);
                if (!HaveStudent(st.StudentID))
                {
                    AddStudent(st);
                }

            }
        }

        public void AddStudentListDataTable(DataTable addedStudentDataTable)
        {
            foreach (DataRow row in addedStudentDataTable.Rows)
            {
                string studentID = row.IsNull(0) ? string.Empty : (string)row[0];
                string firstName = row.IsNull(1) ? string.Empty : (string)row[1];
                string lastName = row.IsNull(2) ? string.Empty : (string)row[2];
                string phoneNumber = row.IsNull(3) ? string.Empty : (string)row[3];
                DateTime birthDay = row.IsNull(4) ? DateTime.MinValue : (DateTime)row[4];
                string gender = row.IsNull(5) ? string.Empty : (string)row[5];
                string address = row.IsNull(6) ? string.Empty : (string)row[6];

                byte[] imageData;
                if (row.IsNull(7))
                {
                    string defaultImagePath = "E:\\hello_csharp\\Day2_Again\\StudentManager\\anh_mac_dinh\\anh_mac_dinh2.jpg";
                    imageData = File.ReadAllBytes(defaultImagePath);
                }
                else
                {
                    imageData = (byte[])row[7];
                }

                Student st = new Student(studentID, firstName, lastName, phoneNumber, birthDay, gender, address, imageData);
                AddStudent(st);
            }
        }

        public bool DeleteStudentList()
        {
            SqlConnection connection = null;
            try
            {

                connection = Connection;
                connection.Open();

                string removeStudentQuery = "DELETE FROM Student";

                SqlCommand removeStudentCmd = new SqlCommand(removeStudentQuery, connection);
                if (removeStudentCmd.ExecuteNonQuery() > 0) return true;
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetStudentDataTableByID:{ex.Message}]");
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close(); // Đóng kết nối sau khi sử dụng xong
                }
            }
        }

        public int CountStudentsByMonth(int month)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "SELECT COUNT(*) FROM Student WHERE MONTH(birthday) = @month";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@month", month);
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CountStudentsByMonth:{ex.Message}]");
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close(); // Đóng kết nối sau khi sử dụng xong
                }
            }
        }

        public int CountStudentInCondition(string condition = null)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "SELECT COUNT(*) FROM Student";

                if (condition != null)
                {
                    query += " WHERE " + condition;
                }

                SqlCommand command = new SqlCommand(query, connection);

                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[CountStudentInCondition:{ex.Message}]");
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
