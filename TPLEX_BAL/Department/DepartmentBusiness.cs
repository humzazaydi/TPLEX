using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TPLEX_DAL.BusinessDTO;
using TPLEX_DAL.Interfaces;

namespace TPLEX_BAL.Department
{
    public class DepartmentBusiness
    {
        private readonly IDepartmentsRepository _departmentsRepository;

        public DepartmentBusiness(IDepartmentsRepository departmentsRepository)
        {
            _departmentsRepository = departmentsRepository;
        }

        public async Task<List<DepartmentDTO>> GetDepartments()
        {
            var departments = await _departmentsRepository.GetDepartments();

            if (departments != null && departments.Count > 0)
                return departments.ConvertAll(DepartmentDTOConversion.ConvertDepartment);
            else
                return null;
        }
        public async Task<DepartmentDTO> GetDepartment(int id)
        {
            return DepartmentDTOConversion.ConvertDepartment(await _departmentsRepository.GetDepartment(id));
        }
        public async Task<DepartmentDTO> PostDepartment(DepartmentDTO department)
        {
            return DepartmentDTOConversion.ConvertDepartment(await _departmentsRepository.PostDepartment(department));
        }
        public async Task<DepartmentDTO> PutDepartment(DepartmentDTO department)
        {
            return DepartmentDTOConversion.ConvertDepartment(await _departmentsRepository.PutDepartment(department));
        }
        public async Task<bool> DeleteDepartment(int id)
        {
            return await _departmentsRepository.DeleteDepartment(id);
        }
    }
}
