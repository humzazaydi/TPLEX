using System;
using System.Collections.Generic;
using System.Text;
using TPLEX_DAL.Model;

namespace TPLEX_DAL.BusinessDTO
{
    public class EmployeeDTOConversion
    {
        public static EmployeeDTO ConvertEmployee(EmployeeModel model)
        {
            return new EmployeeDTO
            {
                employee_id = model.EmployeeId,
                department = model.Department,
                email_address = model.EmailAddress,
                full_name = model.FullName,
                mobile = model.Mobile,
                salary = model.Salary
            };
        }
    }
}
