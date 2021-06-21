using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Entities.Dtos.Department;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Concrete
{
    public class DepartmentManager: IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;
        private readonly IMapper _mapper;
        public DepartmentManager(IDepartmentDal departmentDal, IMapper mapper)
        {
            _departmentDal = departmentDal;
            _mapper = mapper;
        }

        public IDataResult<List<DepartmentDto>> GetAll(int companyId)
        {
            var departments=_departmentDal.GetAll(x => x.Company.Id == companyId);
            var result = _mapper.Map<List<DepartmentDto>>(departments);
            return new SuccessDataResult<List<DepartmentDto>>(result);
        }

        public IDataResult<DepartmentDto> Get(int departmentId)
        {
            var department = _departmentDal.Get(x => x.Id == departmentId);
            var result = _mapper.Map<DepartmentDto>(department);
            return new SuccessDataResult<DepartmentDto>(result);
        }


        public IResult Delete(int departmentId)
        {
            var dbDepartment = _departmentDal.Get(x => x.Id == departmentId);
            _departmentDal.Delete(dbDepartment);
            return new SuccessResult();
        }

        public IResult Update(UpdateDepartmentDto updateDepartmentDepartmentDto)
        {
            var department = _mapper.Map<Department>(updateDepartmentDepartmentDto);
            _departmentDal.Update(department);
            return new SuccessResult();
        }

        public IResult Create(CreateDepartmentDto createDepartmentDto)
        {
            var department = _mapper.Map<Department>(createDepartmentDto);
            _departmentDal.Add(department);
            return new SuccessResult();
        }
    }
}
