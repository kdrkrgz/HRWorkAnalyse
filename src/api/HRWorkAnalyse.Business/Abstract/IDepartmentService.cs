using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Entities.Dtos.Department;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface IDepartmentService
    {
        IDataResult<List<DepartmentDto>> GetAll(int companyId);
        IDataResult<DepartmentDto> Get(int departmentId);
        IResult Delete(int departmentId);
        IResult Update(UpdateDepartmentDto updateDepartmentDepartmentDto);
        IResult Create(CreateDepartmentDto createDepartmentDto);
    }
}
