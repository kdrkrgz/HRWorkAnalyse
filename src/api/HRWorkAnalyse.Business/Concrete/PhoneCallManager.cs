using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Entities.Dtos.PhoneCall;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Concrete
{
    public class PhoneCallManager: IPhoneCallService
    {
        private readonly IPhoneCallDal _phoneCallDal;
        private readonly IMapper _mapper;

        public PhoneCallManager(IMapper mapper, IPhoneCallDal phoneCallDal)
        {
            _mapper = mapper;
            _phoneCallDal = phoneCallDal;
        }

        public IDataResult<List<PhoneCallDto>> GetAll(int employeeId)
        {
            var phoneCalls = _phoneCallDal.GetAll(x => x.Employee.Id == employeeId);
            var result = _mapper.Map<List<PhoneCallDto>>(phoneCalls);
            return new SuccessDataResult<List<PhoneCallDto>>(result);
        }

        public IDataResult<List<PhoneCallDto>> GetByTitle(int titleId)
        {
            var phoneCalls = _phoneCallDal.GetAll(x => x.Employee.TitleId == titleId);
            var result = _mapper.Map<List<PhoneCallDto>>(phoneCalls);
            return new SuccessDataResult<List<PhoneCallDto>>(result);
        }

        public IResult Create(CreatePhoneCallDto createPhoneCallDto)
        {
            var phoneCall = _mapper.Map<PhoneCall>(createPhoneCallDto);
            _phoneCallDal.Add(phoneCall);
            return new SuccessResult();
        }

        public IResult Update(UpdatePhoneCallDto updatePhoneCallDto)
        {
            var phoneCall = _mapper.Map<PhoneCall>(updatePhoneCallDto);
            _phoneCallDal.Update(phoneCall);
            return new SuccessResult();
        }

        public IResult Delete(int phoneCallId)
        {
            var dbPhoneCall = _phoneCallDal.Get(x => x.Id == phoneCallId);
            _phoneCallDal.Delete(dbPhoneCall);
            return new SuccessResult();
        }
    }
}
