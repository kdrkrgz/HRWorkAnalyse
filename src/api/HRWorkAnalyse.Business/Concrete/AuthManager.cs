using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Entities.Concrete;
using HRWorkAnalyse.Core.Entities.Concrete.Dtos;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Core.Utilities.Security.JWT;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Concrete
{
    public class AuthManager: IAuthService
    {

        private readonly ICompanyUserService _companyUserService;
        private readonly ITokenHelper _tokenHelper;
        // TODO: Stay Here.
        //private readonly IOperationClaimService _operationClaimService;
        //private readonly IUserOperationClaimService _userOperationClaimService;
        //private readonly IEmailService _emailService;


        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IResult UserExist(string userEmail)
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public IResult ForgotPassword(string userEmail)
        {
            throw new NotImplementedException();
        }

        public IResult ResetPassword(PasswordResetDto passwordResetDto)
        {
            throw new NotImplementedException();
        }

        public IResult SendActivationToken(CompanyUser user)
        {
            throw new NotImplementedException();
        }

        public IResult ActivateUser(AccountActivateDto accountActivateDto)
        {
            throw new NotImplementedException();
        }
    }
}
