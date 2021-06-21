using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Entities.Dtos.Company;

namespace HRWorkAnalyse.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly IMapper _mapper;
        private readonly ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal, IMapper mapper)
        {
            _companyDal = companyDal;
            _mapper = mapper;
        }

        public IDataResult<CompanyDto> Get(int id)
        {
            var companies = _companyDal.Get(x => x.Id == id && x.IsActive == true);
            CompanyDto company = _mapper.Map<CompanyDto>(companies);
            return new SuccessDataResult<CompanyDto>(company);
        }

        public IDataResult<List<CompanyDto>> GetAll()
        {
            var companies = _companyDal.GetAll();
            List<CompanyDto> companyList = _mapper.Map<List<CompanyDto>>(companies);
            return new SuccessDataResult<List<CompanyDto>>(companyList);
        }

        public IResult Create(CreateCompanyDto companyDto)
        {
            Company company = _mapper.Map<Company>(companyDto);
            company.CreatedDate = DateTime.Now;
            _companyDal.Add(company);
            return new SuccessResult();
        }

        public IResult Update(UpdateCompanyDto companyDto)
        {
            Company company = _mapper.Map<Company>(companyDto);
            company.UpdatedDate = DateTime.Now;
            _companyDal.Update(company);
            return new SuccessResult();
        }

        public IResult Delete(int companyId)
        {
            var dbCompany = _companyDal.Get(x => x.Id == companyId);
            _companyDal.Delete(dbCompany);
            return new SuccessResult();
        }


    }
}
