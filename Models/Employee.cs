using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesSystemAPI.Models
{
    public class Employee
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public DateTime CreatedAt { get; set; }


    }
}
