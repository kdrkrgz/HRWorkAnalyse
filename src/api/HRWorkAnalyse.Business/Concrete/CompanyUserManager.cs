using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Entities.Concrete;
using HRWorkAnalyse.Data.Abstract;

namespace HRWorkAnalyse.Business.Concrete
{
    public class CompanyUserManager: ICompanyUserService
    {
        private readonly ICompanyUserDal _companyUserDal;

        public CompanyUserManager(ICompanyUserDal companyUserDal)
        {
            _companyUserDal = companyUserDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _companyUserDal.GetClaims(user);
        }
    }
}
