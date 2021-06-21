using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Entities.Dtos.Permit;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Concrete
{
    public class PermitManager: IPermitService
    {
        private readonly IPermitDal _permitDal;
        private readonly IMapper _mapper;
        public PermitManager(IPermitDal permitDal, IMapper mapper)
        {
            _permitDal = permitDal;
            _mapper = mapper;
        }

        public IDataResult<List<PermitDto>> GetByTitle(int titleId)
        {
            var permits = _permitDal.GetAll(x => x.Title.Id == titleId);
            var result = _mapper.Map<List<PermitDto>>(permits);
            return new SuccessDataResult<List<PermitDto>>(result);
        }

        public IResult Create(CreatePermitDto createPermitDto)
        {
            var permit = _mapper.Map<Permit>(createPermitDto);
            _permitDal.Add(permit);
            return new SuccessResult();
        }

        public IResult Update(UpdatePermitDto updatePermitDto)
        {
            var permit = _mapper.Map<Permit>(updatePermitDto);
            _permitDal.Update(permit);
            return new SuccessResult();
        }

        public IResult Delete(int permitId)
        {
            var dbPermit = _permitDal.Get(x => x.Id == permitId);
            _permitDal.Delete(dbPermit);
            return new SuccessResult();
        }
    }
}
