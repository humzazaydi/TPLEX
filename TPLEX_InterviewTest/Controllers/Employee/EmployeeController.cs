using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPLEX_BAL.Employee;
using TPLEX_DAL.BusinessDTO;

namespace TPLEX_InterviewTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeBusiness _employeeBusiness;

        public EmployeeController(EmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }

        //GET
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _employeeBusiness.GetEmployees());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET/{employee_id}
        [HttpGet("GetEmployee/{employee_id}")]
        public async Task<IActionResult> Get(int employee_id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _employeeBusiness.GetEmployee(employee_id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //POST
        [HttpPost("PostEmployee")]
        public async Task<IActionResult> Post(EmployeeDTO employee)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _employeeBusiness.PostEmployee(employee));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //PUT
        [HttpPut("PutEmployee")]
        public async Task<IActionResult> Put(EmployeeDTO employee)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _employeeBusiness.PutEmployee(employee));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //DELETE
        [HttpDelete("DeleteEmployee/{employee_id}")]
        public async Task<IActionResult> Delete(int employee_id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _employeeBusiness.DeleteEmployee(employee_id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
