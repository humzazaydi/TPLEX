using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TPLEX_DAL.Model
{
    public class TPLEXContext : DbContext
    {
        public TPLEXContext()
        {

        }
        public TPLEXContext(DbContextOptions<TPLEXContext> options)
            :base(options)
        {

        }

        public virtual DbSet<EmployeeModel> Employees { get; set; }
        public virtual DbSet<DepartmentModel> Departments { get; set; }
    }
}
