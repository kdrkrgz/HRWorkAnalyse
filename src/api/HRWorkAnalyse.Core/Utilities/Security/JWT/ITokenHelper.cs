using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities.Concrete;

namespace HRWorkAnalyse.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
