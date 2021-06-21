using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Entities.Dtos.Mission;
using HRWorkAnalyse.Entities.Dtos.Title;

namespace HRWorkAnalyse.Business.Abstract
{
    public interface IMissionService
    {
        IDataResult<List<MissionDto>> GetAll(int titleId);
        IDataResult<MissionDto> Get(int missionId);
        IResult Create(CreateMissionDto createMissionDto);
        IResult Update(UpdateMissionDto updateMissionDto);
        IResult Delete(int missionId);
    }
}
