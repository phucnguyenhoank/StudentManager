using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Score
    {
            /*
    create table Score (
        studentID varchar(255),
        courseID varchar(50),
	    semester int,
        studentScore decimal(5, 2) not null,
        description nvarchar(255),
        primary key (studentID, courseID, semester),
        foreign key (studentID, courseID, semester) references StudentCourseRegistration(studentID, courseID, semester)
    )
         */
        public string StudentId { get; set; }
        public string CourseId { get; set; }
        public int Semester {  get; set; }
        public decimal StudentScore { get; set; }
        public string Description { get; set; }

        // Constructor with default parameters
        public Score(string studentId = "", string courseId = "", int semester = 0, decimal studentScore = 0.00m, string description = "")
        {
            StudentId = studentId;
            CourseId = courseId;
            Semester = semester;
            StudentScore = studentScore;
            Description = description;
        }
    }

}
