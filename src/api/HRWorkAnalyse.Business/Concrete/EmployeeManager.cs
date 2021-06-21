using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Core.Utilities.Results;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Entities.Dtos.Employee;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Concrete
{
    public class EmployeeManager: IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;
        private readonly IMapper _mapper;
        public EmployeeManager(IEmployeeDal employeeDal, IMapper mapper)
        {
            _employeeDal = employeeDal;
            _mapper = mapper;
        }

        public IDataResult<List<EmployeeDto>> GetByTitle(int titleId)
        {
            var employees = _employeeDal.GetAll(x => x.Title.Id == titleId);
            var result = _mapper.Map<List<EmployeeDto>>(employees);
            return new SuccessDataResult<List<EmployeeDto>>(result);
        }

        public IDataResult<EmployeeDto> Get(int employeeId)
        {
            var employee= _employeeDal.Get(x => x.Id == employeeId);
            var result = _mapper.Map<EmployeeDto>(employee);
            return new SuccessDataResult<EmployeeDto>(result);
        }

        public IResult Create(CreateEmployeeDto createEmployeeDto)
        {
            var employee = _mapper.Map<Employee>(createEmployeeDto);
            _employeeDal.Add(employee);
            return new SuccessResult();
        }

        public IResult Update(UpdateEmployeDto updateEmployeDto)
        {
            var employee = _mapper.Map<Employee>(updateEmployeDto);
            _employeeDal.Update(employee);
            return new SuccessResult();
        }

        public IResult Delete(int employeeId)
        {
            var employee = _employeeDal.Get(x => x.Id == employeeId);
            _employeeDal.Delete(employee);
            return new SuccessResult();
        }
    }
}
