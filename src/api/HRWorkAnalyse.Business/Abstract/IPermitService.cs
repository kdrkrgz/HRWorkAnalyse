using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Entities.Dtos.Permit;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface IPermitService
    {
        IDataResult<List<PermitDto>> GetByTitle(int titleId);
        IResult Create(CreatePermitDto createPermitDto);
        IResult Update(UpdatePermitDto updatePermitDto);
        IResult Delete(int permitId);
    }
}
