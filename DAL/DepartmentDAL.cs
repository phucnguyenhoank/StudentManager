using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using StudentManager;

namespace DAL
{
    public class DepartmentDAL
    {
        private string connectString = SharedConnectString.ConnectString;

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }

        public DataTable GetAllDepartmentsAsDataTable()
        {
            DataTable dtDepartments = new DataTable();
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "SELECT departmentID, departmentName FROM Department;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dtDepartments.Load(reader);
                    }
                }

                return dtDepartments;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetAllDepartments: {ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close(); // Ensure connection is closed regardless of success or failure
                }
            }
        }

        public List<Department> GetAllDepartmentsAsList()
        {
            List<Department> departments = new List<Department>();
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "SELECT departmentID, departmentName FROM Department;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department
                            {
                                DepartmentID = Convert.ToInt32(reader["departmentID"]),
                                DepartmentName = reader["departmentName"].ToString()
                            };
                            departments.Add(department);
                        }
                    }
                }

                return departments; // Trả về danh sách các phòng ban
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetAllDepartmentsAsList: {ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close(); // Ensure connection is closed regardless of success or failure
                }
            }
        }


        public bool DepartmentExists(string departmentName)
        {
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Department WHERE departmentName = @DepartmentName;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentName", departmentName);

                    // Execute the SQL command and get the count of departments with the specified name
                    int count = (int)command.ExecuteScalar();

                    return count > 0; // Return true if there's at least one department with the specified name; otherwise, false
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DepartmentExists:{ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close(); // Ensure connection is closed regardless of success or failure
                }
            }
        }

        public int AddDepartment(Department department)
        {
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "INSERT INTO Department (departmentName) VALUES (@DepartmentName);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentName", department.DepartmentName);
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddDepartment:{ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public int DeleteDepartment(int departmentID)
        {
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "DELETE FROM Department WHERE departmentID = @DepartmentID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);

                    // Execute the SQL command
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected; // Return the number of rows affected (should be 1 for successful deletion)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteDepartment:{ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close(); // Ensure connection is closed regardless of success or failure
                }
            }
        }

        public int DeleteDepartment(string departmentName)
        {
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "DELETE FROM Department WHERE departmentName = @DepartmentName;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DepartmentName", departmentName);

                    // Execute the SQL command
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected; // Return the number of rows affected (should be 1 for successful deletion)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteDepartment:{ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close(); // Ensure connection is closed regardless of success or failure
                }
            }
        }


        public int EditDepartment(int departmentID, string newDepartmentName)
        {
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "UPDATE Department SET departmentName = @NewDepartmentName WHERE departmentID = @DepartmentID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewDepartmentName", newDepartmentName);
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);

                    // Execute the SQL command
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected; // Return the number of rows affected (should be 1 for successful update)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EditDepartment:{ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close(); // Ensure connection is closed regardless of success or failure
                }
            }
        }

        public int EditDepartment(string oldDepartmentName, string newDepartmentName)
        {
            SqlConnection connection = Connection;

            try
            {
                connection.Open();

                string query = "UPDATE Department SET departmentName = @NewDepartmentName WHERE departmentName = @OldDepartmentName;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewDepartmentName", newDepartmentName);
                    command.Parameters.AddWithValue("@OldDepartmentName", oldDepartmentName);

                    // Execute the SQL command
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected; // Return the number of rows affected (should be 1 for successful update)
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EditDepartment:{ex.Message}]");
                throw; // Re-throw the exception for handling at a higher level
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close(); // Ensure connection is closed regardless of success or failure
                }
            }
        }


    }
}
