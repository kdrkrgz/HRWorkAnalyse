using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Entities.Dtos.Title;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface ITitleService
    {
        IDataResult<List<TitleDto>> GetAll(int departmentId);
        IDataResult<TitleDto> Get(int departmentId);
        IResult Create(CreateTitleDto createTitleDto);
        IResult Update(UpdateTitleDto updateTitleDto);
        IResult Delete(int titleId);
    }
}
