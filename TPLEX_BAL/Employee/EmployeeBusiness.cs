using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TPLEX_DAL.BusinessDTO;
using TPLEX_DAL.Interfaces;
using TPLEX_DAL.Model;

namespace TPLEX_BAL.Employee
{
    public class EmployeeBusiness
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeBusiness(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeDTO>> GetEmployees()
        {
            List<EmployeeModel> employees = await _employeeRepository.GetEmployees();
            if (employees != null && employees.Count > 0)
                return employees.ConvertAll(EmployeeDTOConversion.ConvertEmployee);
            else
                return null;
        }
        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            return EmployeeDTOConversion.ConvertEmployee(await _employeeRepository.GetEmployee(id));
        }
        public async Task<EmployeeDTO> PostEmployee(EmployeeDTO employee)
        {
            return EmployeeDTOConversion.ConvertEmployee(await _employeeRepository.PostEmployee(employee));
        }
        public async Task<EmployeeDTO> PutEmployee(EmployeeDTO employee)
        {
            return EmployeeDTOConversion.ConvertEmployee(await _employeeRepository.PutEmployee(employee));
        }
        public async Task<bool> DeleteEmployee(int id)
        {
            return await _employeeRepository.DeleteEmployee(id);
        }
    }
}
