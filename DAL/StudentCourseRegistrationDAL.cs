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
    public class StudentCourseRegistrationDAL
    {
        private string connectString = SharedConnectString.ConnectString;

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(connectString);
            }
        }

        public int AddRegistration(StudentCourseRegistration registration)
        {
            string query = "INSERT INTO StudentCourseRegistration (StudentID, CourseID, Semester) VALUES (@StudentID, @CourseID, @Semester)";

            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", registration.StudentID);
                    command.Parameters.AddWithValue("@CourseID", registration.CourseID);
                    command.Parameters.AddWithValue("@Semester", registration.Semester);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected;
                }
            }
        }

        public bool RemoveRegistration(StudentCourseRegistration registration)
        {
            string query = "DELETE FROM StudentCourseRegistration WHERE StudentID = @StudentID AND CourseID = @CourseID AND Semester = @Semester";

            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", registration.StudentID);
                    command.Parameters.AddWithValue("@CourseID", registration.CourseID);
                    command.Parameters.AddWithValue("@Semester", registration.Semester);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public bool EditRegistration(StudentCourseRegistration oldRegistration, StudentCourseRegistration newRegistration)
        {
            string query = "UPDATE StudentCourseRegistration SET StudentID = @NewStudentID, CourseID = @NewCourseID, Semester = @NewSemester WHERE StudentID = @OldStudentID AND CourseID = @OldCourseID AND Semester = @OldSemester";

            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewStudentID", newRegistration.StudentID);
                    command.Parameters.AddWithValue("@NewCourseID", newRegistration.CourseID);
                    command.Parameters.AddWithValue("@NewSemester", newRegistration.Semester);
                    command.Parameters.AddWithValue("@OldStudentID", oldRegistration.StudentID);
                    command.Parameters.AddWithValue("@OldCourseID", oldRegistration.CourseID);
                    command.Parameters.AddWithValue("@OldSemester", oldRegistration.Semester);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public DataTable GetRegistrationFromCourseID(string courseID)
        {
            DataTable dt = new DataTable();

            string query = @"
        select A.studentID, A.firstName, A.lastName, A.phoneNumber, A.birthday, A.gender, A.address, A.image, B.courseID, B.semester, C.label, C.period, C.description
        from Student A
        inner join
        (select studentID, courseID, semester
        from StudentCourseRegistration
        where courseID = @CourseID) B
        on A.studentID = B.studentID
        inner join Course C
        on B.courseID = C.courseID";

            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", courseID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable GetRegisterCoursesOfStudent(string studentID, int semester = 0)
        {
            DataTable dt = new DataTable();

            string query = "SELECT SCR.semester, C.courseID, C.label, C.period, C.description " +
                           "FROM StudentCourseRegistration SCR " +
                           "INNER JOIN Course C ON SCR.courseID = C.courseID " +
                           "WHERE SCR.studentID = @studentID ";

            if (semester > 0)
            {
                query += "AND SCR.semester = @semester";
            }

            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    if (semester > 0)
                    {
                        command.Parameters.AddWithValue("@semester", semester);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public bool HaveRegistration(string studentID, string courseID, int semester)
        {
            string query = "SELECT COUNT(*) " +
                           "FROM StudentCourseRegistration " +
                           "WHERE studentID = @studentID " +
                           "AND courseID = @courseID " +
                           "AND semester = @semester";

            using (SqlConnection connection = Connection)
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.Parameters.AddWithValue("@courseID", courseID);
                    command.Parameters.AddWithValue("@semester", semester);

                    int count = (int)command.ExecuteScalar(); // Đếm số lượng bản ghi

                    return count > 0;
                }
            }

        }
    }

}
