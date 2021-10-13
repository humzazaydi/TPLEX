using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLEX_DAL.BusinessDTO;
using TPLEX_DAL.Model;

namespace TPLEX_DAL.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeModel>> GetEmployees();
        Task<EmployeeModel> GetEmployee(int id);
        Task<EmployeeModel> PostEmployee(EmployeeDTO employee);
        Task<EmployeeModel> PutEmployee(EmployeeDTO employee);
        Task<bool> DeleteEmployee(int id);
    }
}
