using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Entities.Dtos.Employee;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<EmployeeDto>> GetByTitle(int titleId);
        IDataResult<EmployeeDto> Get(int employeeId);
        IResult Create(CreateEmployeeDto createEmployeeDto);
        IResult Update(UpdateEmployeDto updateEmployeDto);
        IResult Delete(int employeeId);
    }
}
