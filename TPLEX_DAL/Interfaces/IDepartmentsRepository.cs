using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLEX_DAL.BusinessDTO;
using TPLEX_DAL.Model;

namespace TPLEX_DAL.Interfaces
{
    public interface IDepartmentsRepository
    {
        Task<List<DepartmentModel>> GetDepartments();
        Task<DepartmentModel> GetDepartment(int id);
        Task<DepartmentModel> PostDepartment(DepartmentDTO department);
        Task<DepartmentModel> PutDepartment(DepartmentDTO department);
        Task<bool> DeleteDepartment(int id);
    }
}
