using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /*
     
create table Teach (
	teachID varchar(50),
	contactID varchar(50),
	courseID varchar(50),
	primary key (teachID),
	foreign key (contactID) references Contact(contactID),
	foreign key (courseID) references Course(CourseID)
)
     */
    public class Teach
    {
        public string TeachID { get; set; }
        public string ContactID { get; set; }
        public string CourseID { get; set; }

        public Teach(string teachID = "defaultTeachID", string contactID = "defaultContactID", string courseID = "defaultCourseID")
        {
            TeachID = teachID;
            ContactID = contactID;
            CourseID = courseID;
        }
    }

}
