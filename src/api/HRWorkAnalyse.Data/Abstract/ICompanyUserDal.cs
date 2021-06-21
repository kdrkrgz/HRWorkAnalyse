using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Data;
using HRWorkAnalyse.Core.Entities.Concrete;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Data.Abstract
{
    public interface ICompanyUserDal: IEntityRepository<CompanyUser>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
