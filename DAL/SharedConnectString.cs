using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BCrypt;
using DTO;
using Microsoft.ReportingServices.Diagnostics.Internal;



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


create table Course (
	courseID varchar(50),
	label nvarchar(100),
	period int,
	description nvarchar(255),
	primary key (courseID)
)




create table Score (
	studentID varchar(255),
	courseID varchar(50),
	studentScore decimal(5, 2) not null,
	description nvarchar(255),
	primary key (studentID, courseID),
	foreign key (studentID) references Student(studentID),
	foreign key (courseID) references Course(courseID)
)



create table StudentCourseRegistration (
	studentID varchar(255),
	courseID varchar(50),
	semester int not null,
	primary key (studentID, courseID, semester),
	foreign key (studentID) references Student(studentID),
	foreign key (courseID) references Course(courseID)
)



create table Account (
	username varchar(100),
	hashedPassword varchar(100),
	email varchar(100) unique,
	isAdmin bit,
	primary key (username)
)
 
 */

/*
 DỮ LIỆU VÀO PHẢI HỢP LÝ
VIỆC GIỮ CHO DỮ LIỆU LUÔN HỢP LÝ THUỘC VỀ TRÁCH NHIỆM CỦA LỚP KHÁC
Ở ĐÂY CHỈ XỬ LÝ NGOẠI LỆ LOGIC CODE, KHÔNG XỬ LÝ NGOẠI LỆ LOGIC NGHIỆP VỤ CỦA ỨNG DỤNG
 */
namespace StudentManager
{
    public static class SharedConnectString
    {
        public static string ConnectString = "Server=xichxo\\SQLEXPRESS;Database=ManagerStudentDB;Integrated Security=True;";
        // public static string ConnectString = "Server=192.168.1.2,1433;Database=ManagerStudentDB;User Id = sa; Password=12345;";
    }
   
}
