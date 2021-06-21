using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Entities.Dtos.Company;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<List<CompanyDto>> GetAll();
        IDataResult<CompanyDto> Get(int id);
        IResult Create(CreateCompanyDto companyDto);
        IResult Update(UpdateCompanyDto companyDto);
        IResult Delete(int companyId);
    }
}
