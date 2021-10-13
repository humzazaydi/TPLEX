using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TPLEX_DAL.Model
{
    public class DepartmentModel
    {
        [Key]
        public int      DepartmentId                  { get; set; }
        public string   Deparment                     { get; set; }
        public int      CreatedBy                     { get; set; }
        public DateTime CreatedTimeStamp              { get; set; }
    }
}
