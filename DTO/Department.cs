using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Department(int departmentID=0, string departmentName="")
        {
            this.DepartmentID = departmentID;
            this.DepartmentName = departmentName;
        }
    }
}
