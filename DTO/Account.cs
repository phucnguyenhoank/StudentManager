using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        /*
        CREATE TABLE Account (
            username VARCHAR(255),
            hashedPassword VARCHAR(255),
            email VARCHAR(255),
            isAdmin BIT, 
            type VARCHAR(50),
	        primary key (username)
        );
         */
        private string username;
        private string hashedPassword;
        private string email;
        private bool isAdmin; // admin can change anything, even with his type and authority
        private string type; // student, human resources manager

        public Account(string username = "", string hashedPassword = "", string email = "", bool isAdmin = false, string type = "")
        {
            this.username = username;
            this.hashedPassword = hashedPassword;
            this.email = email;
            this.isAdmin = isAdmin;
            this.type = type;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string HashedPassword
        {
            get { return hashedPassword; }
            set { hashedPassword = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }

}
