using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentCourseRegistration
    {
        /*
         create table StudentCourseRegistration (
	        studentID varchar(255),
	        courseID varchar(50),
	        semester int not null,
	        primary key (studentID, courseID, semester),
	        foreign key (studentID) references Student(studentID),
	        foreign key (courseID) references Course(courseID)
        )
         */
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public int Semester {  get; set; }

        public StudentCourseRegistration(string studentID = "defaultStudentID", string courseID = "defaultCourseID", int semester=0)
        {
            StudentID = studentID;
            CourseID = courseID;
            Semester = semester;
        }
    }

}
