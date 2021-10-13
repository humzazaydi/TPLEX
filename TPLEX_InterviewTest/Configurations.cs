using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLEX_BAL.Department;
using TPLEX_BAL.Employee;
using TPLEX_DAL.Interfaces;
using TPLEX_DAL.Repositories;

namespace TPLEX_InterviewTest
{
    public class Configurations
    {
        public static void AddToScoped(IServiceCollection services)
        {
            //Business Injection
            services.AddScoped<EmployeeBusiness, EmployeeBusiness>();
            services.AddScoped<DepartmentBusiness, DepartmentBusiness>();

            //Repositories Injection
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentsRepository, DepartmentsRepository>();
        }
    }
}
