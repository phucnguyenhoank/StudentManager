using DTO;
using StudentManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        private string connectString = SharedConnectString.ConnectString;

        // return a new SqlConnection object of the ManagerStudentDB database
        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }

        // return the hashed string of the given password string
        // the result is different at each time this function hashes even with the same given password string
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
        }

        // return true if hashedPassword is password's
        private bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        // Add a new account to the Account table
        public bool AddAccount(Account account)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand insertAccountCmd = connection.CreateCommand();
                insertAccountCmd.CommandText = "INSERT INTO Account (username, hashedPassword, email, isAdmin, type) " +
                    "VALUES (@username, @password, @email, @isAdmin, @type)";
                insertAccountCmd.Parameters.AddWithValue("@username", account.Username);
                insertAccountCmd.Parameters.AddWithValue("@password", account.HashedPassword);
                insertAccountCmd.Parameters.AddWithValue("@email", account.Email);
                insertAccountCmd.Parameters.AddWithValue("@isAdmin", account.IsAdmin);
                insertAccountCmd.Parameters.AddWithValue("@type", account.Type);

                if (insertAccountCmd.ExecuteNonQuery() == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddAccount:{ex.Message}]");
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

        public Account GetAccountByUsername(string username)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand selectAccountCmd = connection.CreateCommand();
                selectAccountCmd.CommandText = "SELECT username, hashedPassword, email, isAdmin, type FROM Account WHERE username = @username";
                selectAccountCmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = selectAccountCmd.ExecuteReader();
                if (reader.Read())
                {
                    Account account = new Account();
                    account.Username = reader["username"].ToString();
                    account.HashedPassword = reader["hashedPassword"].ToString();
                    account.Email = reader["email"].ToString();
                    account.IsAdmin = Convert.ToBoolean(reader["isAdmin"]);
                    account.Type = reader["type"].ToString();

                    return account;
                }

                return null; // No account found with the given username
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetAccountByUsername:{ex.Message}]");
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

        public bool UpdateAccount(Account account)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand updateAccountCmd = connection.CreateCommand();
                updateAccountCmd.CommandText = "UPDATE Account SET hashedPassword = @password, email = @email, "
                                              + "isAdmin = @isAdmin, type = @type WHERE username = @username";
                updateAccountCmd.Parameters.AddWithValue("@password", account.HashedPassword);
                updateAccountCmd.Parameters.AddWithValue("@email", account.Email);
                updateAccountCmd.Parameters.AddWithValue("@isAdmin", account.IsAdmin);
                updateAccountCmd.Parameters.AddWithValue("@type", account.Type);
                updateAccountCmd.Parameters.AddWithValue("@username", account.Username);

                if (updateAccountCmd.ExecuteNonQuery() == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdateAccount:{ex.Message}]");
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

        public bool DeleteAccount(string username)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand deleteAccountCmd = connection.CreateCommand();
                deleteAccountCmd.CommandText = "DELETE FROM Account WHERE username = @username";
                deleteAccountCmd.Parameters.AddWithValue("@username", username);

                if (deleteAccountCmd.ExecuteNonQuery() == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteAccount:{ex.Message}]");
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

        // __________________________________

        // Delete all rows of the Account table
        public bool DeleteAccountList()
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string removeStudentQuery = "DELETE FROM Account";
                SqlCommand removeStudentCmd = new SqlCommand(removeStudentQuery, connection);

                if (removeStudentCmd.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteAccountList:{ex.Message}]");
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

       


        public bool SetAdminValue(string username, bool isAdmin)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE Account SET isAdmin = @isAdmin WHERE username = @username ";
                cmd.Parameters.AddWithValue("@isAdmin", isAdmin);
                cmd.Parameters.AddWithValue("@username", username);
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SetAdmin:{ex.Message}]");
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

        public DataTable GetAccountList()
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string query = "SELECT * FROM Account";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetAccountList:{ex.Message}]");
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

        public void UpdatePassword(string email, string newPassword)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                // Tạo câu lệnh UPDATE
                string updateStatement = "UPDATE Account SET hashedPassword = @newHashedPassword WHERE email = @email";

                // Tạo và mở đối tượng Command
                SqlCommand command = new SqlCommand(updateStatement, connection);

                // Thay thế các tham số trong câu lệnh UPDATE bằng giá trị thực tế
                command.Parameters.AddWithValue("@newHashedPassword", HashPassword(newPassword));
                command.Parameters.AddWithValue("@email", email);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[UpdatePassword:{ex.Message}]");
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

        public bool HaveUsername(string userName)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand checkingCmd = new SqlCommand("SELECT * FROM Account WHERE username = @username", connection);
                checkingCmd.Parameters.AddWithValue("@username", userName);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = checkingCmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HaveUsername:{ex.Message}]");
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

        public bool HaveEmail(string email)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand checkingCmd = new SqlCommand("SELECT * FROM Account WHERE email = @email", connection);
                checkingCmd.Parameters.AddWithValue("@email", email);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = checkingCmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count == 1) return true;
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HaveEmail:{ex.Message}]");
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

        public bool HaveAccount(string userName, string passWord)
        {
            if (HaveUsername(userName) && VerifyPassword(passWord, GetHashPasswordFromDB(userName))) return true;
            return false;
        }

        public bool DeleteAccount(string userName, string passWord)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string hashedPasswordFromDatabase = GetHashPasswordFromDB(userName);

                if (VerifyPassword(passWord, hashedPasswordFromDatabase))
                {
                    string deleteQuery = "DELETE " +
                        "FROM Account " +
                        "WHERE username = @username";

                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@username", userName);
                    deleteCmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DeleteAccount:{ex.Message}]");
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

        private string GetHashPasswordFromDB(string userName)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string getHashQuery = "SELECT hashedPassword " +
                    "FROM Account " +
                    "WHERE username = @username";
                SqlCommand getHashCmd = new SqlCommand(getHashQuery, connection);

                getHashCmd.Parameters.AddWithValue("@username", userName);

                SqlDataReader reader = getHashCmd.ExecuteReader();
                reader.Read();
                return (string)reader["hashedPassword"];


            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetHashPasswordFromDB:{ex.Message}]");
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
