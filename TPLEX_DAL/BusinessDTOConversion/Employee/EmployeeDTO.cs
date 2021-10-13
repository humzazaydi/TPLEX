using System;
using System.Collections.Generic;
using System.Text;

namespace TPLEX_DAL.BusinessDTO
{
    public class EmployeeDTO
    {
        public int employee_id { get; set; }
        public string full_name { get; set; }
        public string email_address { get; set; }
        public string mobile { get; set; }
        public int department { get; set; }
        public double salary { get; set; }
    }
}
