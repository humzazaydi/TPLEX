using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLEX_BAL.Department;
using TPLEX_DAL.BusinessDTO;

namespace TPLEX_InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly DepartmentBusiness _departmentBusiness;

        public DepartmentsController(DepartmentBusiness departmentBusiness)
        {
            _departmentBusiness = departmentBusiness;
        }

        //GET
        [HttpGet("GetDepartments")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _departmentBusiness.GetDepartments());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET/{department_id}
        [HttpGet("GetDepartment/{department_id}")]
        public async Task<IActionResult> Get(int department_id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _departmentBusiness.GetDepartment(department_id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //POST
        [HttpPost("PostDepartment")]
        public async Task<IActionResult> Post(DepartmentDTO department)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _departmentBusiness.PostDepartment(department));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //PUT
        [HttpPut("PutDepartment")]
        public async Task<IActionResult> Put(DepartmentDTO department)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _departmentBusiness.PutDepartment(department));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //DELETE/{department_id}
        [HttpDelete("DeleteDepartment/{department_id}")]
        public async Task<IActionResult> Delete(int department_id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _departmentBusiness.DeleteDepartment(department_id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
