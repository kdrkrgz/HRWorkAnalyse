using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities.Concrete;
using HRWorkAnalyse.Core.Utilities.Results;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface ICompanyUserService
    {
        List<OperationClaim> GetClaims(User user);
    }
}
