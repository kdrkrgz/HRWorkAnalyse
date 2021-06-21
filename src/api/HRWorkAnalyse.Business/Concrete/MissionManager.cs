using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Entities.Dtos.Mission;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Concrete
{
    public class MissionManager: IMissionService
    {
        private readonly IMissionDal _missionDal;
        private readonly IMapper _mapper;

        public MissionManager(IMissionDal missionDal, IMapper mapper)
        {
            _missionDal = missionDal;
            _mapper = mapper;
        }

        public IDataResult<List<MissionDto>> GetAll(int titleId)
        {
            var missions = _missionDal.GetAll(x => x.Title.Id == titleId);
            var result = _mapper.Map<List<MissionDto>>(missions);
            return new SuccessDataResult<List<MissionDto>>(result);
        }

        public IDataResult<MissionDto> Get(int missionId)
        {
            var mission = _missionDal.Get(x => x.Id == missionId);
            var result = _mapper.Map<MissionDto>(mission);
            return new SuccessDataResult<MissionDto>(result);
        }

        public IResult Create(CreateMissionDto createMissionDto)
        {
            var mission = _mapper.Map<Mission>(createMissionDto);
            _missionDal.Add(mission);
            return new SuccessResult();
        }

        public IResult Update(UpdateMissionDto updateMissionDto)
        {
            var mission = _mapper.Map<Mission>(updateMissionDto);
            _missionDal.Add(mission);
            return new SuccessResult();
        }

        public IResult Delete(int missionId)
        {
            var mission = _missionDal.Get(x => x.Id == missionId);
            _missionDal.Delete(mission);
            return new SuccessResult();
        }
    }
}
