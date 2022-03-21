using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDashBoardAppRp.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }

    }
}