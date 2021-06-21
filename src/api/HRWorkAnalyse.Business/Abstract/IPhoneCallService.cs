using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Entities.Dtos.PhoneCall;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface IPhoneCallService
    {
        IDataResult<List<PhoneCallDto>> GetAll(int employeeId);
        IDataResult<List<PhoneCallDto>> GetByTitle(int titleId);
        IResult Create(CreatePhoneCallDto createPhoneCallDto);
        IResult Update(UpdatePhoneCallDto updatePhoneCallDto);
        IResult Delete(int phoneCallId);
    }
}
