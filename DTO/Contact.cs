using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class Contact
    {
        public string ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentID { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public byte[] Picture { get; set; }

        // Constructor with default parameter values
        public Contact(string contactID = "", string firstName = "", string lastName = "",
                       int departmentID = 0, string phoneNumber = "", string email = "",
                       string address = "", byte[] picture = null)
        {
            ContactID = contactID;
            FirstName = firstName;
            LastName = lastName;
            DepartmentID = departmentID;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            Picture = picture;
        }
    }
}
