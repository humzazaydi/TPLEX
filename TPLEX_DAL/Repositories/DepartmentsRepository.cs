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
    public class DepartmentsRepository : IDepartmentsRepository
    {
        private readonly TPLEXContext _context;

        public DepartmentsRepository(TPLEXContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteDepartment(int id)
        {
            try
            {
                var department = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == id);
                if (department != null)
                {
                    _context.Departments.Remove(department);
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

        public async Task<DepartmentModel> GetDepartment(int id)
        {
            try
            {
                var department = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == id);
                if (department != null)
                {
                    return department;
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

        public async Task<List<DepartmentModel>> GetDepartments()
        {
            try
            {
                var department = await _context.Departments.ToListAsync();
                if (department != null)
                {
                    return department;
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

        public async Task<DepartmentModel> PostDepartment(DepartmentDTO department)
        {
            try
            {
                DepartmentModel _department = new DepartmentModel
                {
                    DepartmentId = department.department_id,
                    Deparment = department.deparment,
                    CreatedBy = department.department_id,
                    CreatedTimeStamp = DateTime.Now
                };

                await _context.Departments.AddAsync(_department);
                await _context.SaveChangesAsync();
                return _department;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<DepartmentModel> PutDepartment(DepartmentDTO department)
        {
            try
            {
                DepartmentModel _department = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == department.department_id);
                if (_department != null)
                {
                    _department.Deparment = department.deparment;
                    _context.Entry(_department).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                return _department;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
