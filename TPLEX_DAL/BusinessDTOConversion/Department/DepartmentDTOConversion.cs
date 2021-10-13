using System;
using System.Collections.Generic;
using System.Text;
using TPLEX_DAL.Model;

namespace TPLEX_DAL.BusinessDTO
{
    public class DepartmentDTOConversion
    {
        public static DepartmentDTO ConvertDepartment(DepartmentModel model)
        {
            return new DepartmentDTO
            {
                department_id = model.DepartmentId,
                deparment = model.Deparment
            };
        }
    }
}
