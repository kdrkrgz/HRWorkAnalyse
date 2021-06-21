using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Entities.Dtos.Title;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Concrete
{
    public class TitleManager: ITitleService
    {
        private readonly ITitleDal _titleDal;
        private readonly IMapper _mapper;

        public TitleManager(ITitleDal titleDal, IMapper mapper)
        {
            _titleDal = titleDal;
            _mapper = mapper;
        }

        public IDataResult<List<TitleDto>> GetAll(int departmentId)
        {
            var titles = _titleDal.GetAll(x => x.Department.Id == departmentId);
            var result = _mapper.Map<List<TitleDto>>(titles);
            return new SuccessDataResult<List<TitleDto>>(result);
        }

        public IDataResult<TitleDto> Get(int departmentId)
        {
            var title= _titleDal.Get(x => x.Id == departmentId);
            var result = _mapper.Map<TitleDto>(title);
            return new SuccessDataResult<TitleDto>(result);
        }

        public IResult Create(CreateTitleDto createTitleDto)
        {
            var title = _mapper.Map<Title>(createTitleDto);
            _titleDal.Add(title);
            return new SuccessResult();
        }

        public IResult Update(UpdateTitleDto updateTitleDto)
        {
            var title = _mapper.Map<Title>(updateTitleDto);
            _titleDal.Update(title);
            return new SuccessResult();
        }

        public IResult Delete(int titleId)
        {
            var dbTitle = _titleDal.Get(x => x.Id == titleId);
            _titleDal.Delete(dbTitle);
            return new SuccessResult();
        }
    }
}
