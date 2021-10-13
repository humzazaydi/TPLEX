using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TPLEX_DAL.Model
{
    public class EmployeeModel
    {
        [Key]
        public int      EmployeeId                  { get; set; }
        public string   FullName                    { get; set; }
        public string   EmailAddress                { get; set; }
        public string   Mobile                      { get; set; }
        public int      Department                  { get; set; }
        public double   Salary                      { get; set; }
        public int      CreatedBy                   { get; set; }
        public DateTime CreatedTimeStamp            { get; set; }
    }
}
