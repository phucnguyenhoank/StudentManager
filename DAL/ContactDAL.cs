using StudentManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class ContactDAL
    {
        private string connectString = SharedConnectString.ConnectString;

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }

        public int AddContact(Contact contact)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string insertStudentQuery = "INSERT INTO Contact " +
                        "VALUES " +
                        "(@contactID, @firstName, @lastName, @departmentID, @phoneNumber, @email, @address, @picture)";

                SqlCommand insertStudentCmd = new SqlCommand(insertStudentQuery, connection);
                insertStudentCmd.Parameters.AddWithValue("@contactID", contact.ContactID);
                insertStudentCmd.Parameters.AddWithValue("@firstName", contact.FirstName);
                insertStudentCmd.Parameters.AddWithValue("@lastName", contact.LastName);
                insertStudentCmd.Parameters.AddWithValue("@departmentID", contact.DepartmentID);
                insertStudentCmd.Parameters.AddWithValue("@phoneNumber", contact.PhoneNumber);
                insertStudentCmd.Parameters.AddWithValue("@email", contact.Email);
                insertStudentCmd.Parameters.AddWithValue("@address", contact.Address);
                insertStudentCmd.Parameters.AddWithValue("@picture", contact.Picture);

                int n = insertStudentCmd.ExecuteNonQuery();
                return n;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[AddContact:{ex.Message}]");
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

        public int RemoveContact(string contactID)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string removeContactQuery = "DELETE FROM Contact " +
                                            "WHERE ContactID = @contactID";
                SqlCommand removeContactCmd = new SqlCommand(removeContactQuery, connection);
                removeContactCmd.Parameters.AddWithValue("@contactID", contactID);

                int rowsAffected = removeContactCmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[RemoveContact: {ex.Message}]");
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

        public int EditContact(Contact contact)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                string editContactQuery = "UPDATE Contact " +
                                          "SET FirstName = @firstName, " +
                                          "    LastName = @lastName, " +
                                          "    DepartmentID = @departmentID, " +
                                          "    PhoneNumber = @phoneNumber, " +
                                          "    Email = @email, " +
                                          "    Address = @address, " +
                                          "    Picture = @picture " +
                                          "WHERE ContactID = @contactID";

                SqlCommand editContactCmd = new SqlCommand(editContactQuery, connection);
                editContactCmd.Parameters.AddWithValue("@firstName", contact.FirstName);
                editContactCmd.Parameters.AddWithValue("@lastName", contact.LastName);
                editContactCmd.Parameters.AddWithValue("@departmentID", contact.DepartmentID);
                editContactCmd.Parameters.AddWithValue("@phoneNumber", contact.PhoneNumber);
                editContactCmd.Parameters.AddWithValue("@email", contact.Email);
                editContactCmd.Parameters.AddWithValue("@address", contact.Address);
                editContactCmd.Parameters.AddWithValue("@picture", contact.Picture);
                editContactCmd.Parameters.AddWithValue("@contactID", contact.ContactID);

                int rowsAffected = editContactCmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[EditContact: {ex.Message}]");
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

        public bool HaveContact(string contactID)
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand checkingCmd = new SqlCommand("SELECT COUNT(*) FROM Contact WHERE ContactID = @contactID", connection);
                checkingCmd.Parameters.AddWithValue("@contactID", contactID);

                int count = Convert.ToInt32(checkingCmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HaveContact: {ex.Message}]");
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

        public DataTable GetContactsAsDataTable()
        {
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Contact", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetContactsAsDataTable: {ex.Message}]");
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

        public List<Contact> GetContactsAsList()
        {
            List<Contact> contacts = new List<Contact>();
            SqlConnection connection = null;
            try
            {
                connection = Connection;
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Contact", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Contact contact = new Contact
                    {
                        ContactID = reader["ContactID"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        DepartmentID = Convert.ToInt32(reader["DepartmentID"]),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        Email = reader["Email"].ToString(),
                        Address = reader["Address"].ToString(),
                        Picture = reader["Picture"] as byte[]
                    };

                    contacts.Add(contact);
                }

                return contacts;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetContactsAsList: {ex.Message}]");
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
