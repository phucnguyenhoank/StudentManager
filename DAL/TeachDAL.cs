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
    public class TeachDAL
    {
        private string connectString = SharedConnectString.ConnectString;

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }

        public void CreateTeach(Teach teach)
        {
            try
            {
                string query = "INSERT INTO Teach (teachID, contactID, courseID) VALUES (@teachID, @contactID, @courseID)";

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@teachID", teach.TeachID);
                    command.Parameters.AddWithValue("@contactID", teach.ContactID);
                    command.Parameters.AddWithValue("@courseID", teach.CourseID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CreateTeach:{ex.Message}");
                throw;
            }
        }

        public Teach ReadTeach(string teachID)
        {
            try
            {
                Teach teach = null;
                string query = "SELECT * FROM Teach WHERE teachID = @teachID";

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@teachID", teachID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        teach = new Teach
                        {
                            TeachID = reader["teachID"].ToString(),
                            ContactID = reader["contactID"].ToString(),
                            CourseID = reader["courseID"].ToString()
                        };
                    }
                }

                return teach;
            }
            catch (Exception ex)
            {
                Console.WriteLine($":{ex.Message}");
                throw;
            }

        }

        public void UpdateTeach(Teach teach)
        {
            try
            {
                string query = "UPDATE Teach SET contactID = @contactID, courseID = @courseID WHERE teachID = @teachID";

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@teachID", teach.TeachID);
                    command.Parameters.AddWithValue("@contactID", teach.ContactID);
                    command.Parameters.AddWithValue("@courseID", teach.CourseID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($":{ex.Message}");
                throw;
            }

            
        }

        public void DeleteTeach(string teachID)
        {
            try
            {
                string query = "DELETE FROM Teach WHERE teachID = @teachID";

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@teachID", teachID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($":{ex.Message}");
                throw;
            }
        }

        public List<Teach> GetAllTeachsAsList(string contactID = null)
        {
            List<Teach> teachs = new List<Teach>();

            try
            {
                string query = contactID == null ? "SELECT * FROM Teach" : "SELECT * FROM Teach WHERE contactID = @contactID";

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    if (contactID != null)
                    {
                        command.Parameters.AddWithValue("@contactID", contactID);
                    }

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Teach teach = new Teach
                        {
                            TeachID = reader["teachID"].ToString(),
                            ContactID = reader["contactID"].ToString(),
                            CourseID = reader["courseID"].ToString()
                        };

                        teachs.Add(teach);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GetAllTeachsAsList:{ex.Message}");
                throw;
            }

            return teachs;
        }

        public DataTable GetAllTeachsAsDataTable(string contactID = null)
        {
            try
            {
                string query = contactID == null ? "SELECT * FROM Teach" : "SELECT * FROM Teach WHERE contactID = @contactID";
                var dataTable = new DataTable();

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    if (contactID != null)
                    {
                        command.Parameters.AddWithValue("@contactID", contactID);
                    }

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GetAllTeachsAsDataTable:{ex.Message}");
                throw;
            }
        }


        public bool IsTeachExist(string teachID)
        {
            bool isExist = false;

            try
            {
                string query = "SELECT COUNT(*) FROM Teach WHERE teachID = @teachID";

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@teachID", teachID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        isExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"IsTeachExist:{ex.Message}");
                throw;
            }

            return isExist;
        }


        public bool IsTeachExist(string contactID, string courseID)
        {
            bool isExist = false;

            try
            {
                string query = "SELECT COUNT(*) FROM Teach WHERE contactID = @contactID and courseID = @courseID";

                using (SqlConnection connection = Connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@contactID", contactID);
                    command.Parameters.AddWithValue("@courseID", courseID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        isExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"IsTeachExist:{ex.Message}");
                throw;
            }

            return isExist;
        }


    }

}
