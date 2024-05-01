using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Course
    {
        /*
        create table Course (
	        courseID varchar(50),
	        label nvarchar(100),
	        period int,
	        description nvarchar(255),
	        primary key (courseID)
        )
         
         */

        public Course(string courseID = "", string label = "", int period = 0, string description = "")
        {
            this.CourseID = courseID;
            this.Label = label;
            this.Period = period;
            this.Description = description;
        }
        public string CourseID { get; set; }
        public string Label { get; set; }
        public int Period { get; set; }
        public string Description { get; set; }

    }
}
