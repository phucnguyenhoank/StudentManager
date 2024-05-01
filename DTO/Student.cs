using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Student
    {
        /*
        create table Student (
	        studentID varchar(255),
	        firstName nvarchar(255),
	        lastName nvarchar(255),
	        phoneNumber varchar(255),
	        birthday datetime,
	        gender varchar(20),
	        address nvarchar(255),
	        image varbinary(max),
	        primary key (studentID)
        )
         */
        private string studentID, firstName, lastName, phoneNumber, address;
        DateTime birthday;
        string gender;    // True is Male, False is Female
        byte[] image;

        public Student() { }

        public Student(string studentID = "", string firstName = "", string lastName = "", string phoneNumber = "", DateTime? birthday = null, string gender = "", string address = "", byte[] image = null)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Birthday = birthday ?? DateTime.MinValue;
            Gender = gender;
            Address = address;
            Image = image;
        }

        public string StudentID { get { return studentID; } set { studentID = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime Birthday { get {  return birthday; } set {  birthday = value; } }
        public string Gender { get {  return gender; } set {  gender = value; } }
        public string PhoneNumber { get {  return phoneNumber; } set {  phoneNumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public byte[] Image { get { return image; } set {  image = value; } }

    }
}
