using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Entities.Concrete;
using HRWorkAnalyse.Core.Entities.Concrete.Dtos;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Core.Utilities.Security;
using HRWorkAnalyse.Core.Utilities.Security.JWT;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExist(string userEmail);
        IDataResult<AccessToken> CreateAccessToken(User user);
        IResult ForgotPassword(string userEmail);
        IResult ResetPassword(PasswordResetDto passwordResetDto);
        IResult SendActivationToken(CompanyUser user);
        IResult ActivateUser(AccountActivateDto accountActivateDto);
    }
}
