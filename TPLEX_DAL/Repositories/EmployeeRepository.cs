using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLEX_DAL.BusinessDTO;
using TPLEX_DAL.Interfaces;
using TPLEX_DAL.Model;

namespace TPLEX_DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TPLEXContext _context;

        public EmployeeRepository(TPLEXContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            try
            {
                var employee = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<EmployeeModel> GetEmployee(int id)
        {
            try
            {
                var employee = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            try
            {
                var employees = await _context.Employees.ToListAsync();
                if (employees != null)
                {
                    return employees;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<EmployeeModel> PostEmployee(EmployeeDTO employee)
        {
            try
            {
                EmployeeModel _employee = new EmployeeModel
                {
                    EmployeeId = employee.employee_id,
                    FullName = employee.full_name,
                    EmailAddress = employee.email_address,
                    Mobile = employee.mobile,
                    Department = employee.department,
                    Salary = employee.salary,
                    CreatedBy = employee.employee_id,
                    CreatedTimeStamp = DateTime.Now
                };

                await _context.Employees.AddAsync(_employee);
                await _context.SaveChangesAsync();
                return _employee;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<EmployeeModel> PutEmployee(EmployeeDTO employee)
        {
            try
            {
                EmployeeModel _employee = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == employee.employee_id);
                if (_employee != null)
                {
                    _employee.FullName = employee.full_name;
                    _employee.EmailAddress = employee.email_address;
                    _employee.Mobile = employee.mobile;
                    _employee.Department = employee.department;
                    _employee.Salary = employee.salary;

                    _context.Entry(_employee).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                return _employee;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

