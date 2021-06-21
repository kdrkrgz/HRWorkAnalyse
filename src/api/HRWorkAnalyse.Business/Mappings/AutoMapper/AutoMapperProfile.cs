using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HRWorkAnalyse.Entities.Dtos.Company;
using HRWorkAnalyse.Entities.Dtos.Department;
using HRWorkAnalyse.Entities.Dtos.Employee;
using HRWorkAnalyse.Entities.Dtos.Mission;
using HRWorkAnalyse.Entities.Dtos.Permit;
using HRWorkAnalyse.Entities.Dtos.PhoneCall;
using HRWorkAnalyse.Entities.Dtos.Title;
using HRWorkAnalyse.Entities.Entities;

namespace HRWorkAnalyse.Business.Mappings.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            // source to domain
            CreateMap<Company, CompanyDto>();
            CreateMap<Department, DepartmentDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Title, TitleDto>();
            CreateMap<Mission, MissionDto>();
            CreateMap<Permit, PermitDto>();
            CreateMap<PhoneCall, PhoneCallDto>();

            // domain to source
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<UpdateCompanyDto, Company>();
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto, Department>();
            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<UpdateEmployeDto, Employee>();
            CreateMap<CreateTitleDto, Title>();
            CreateMap<UpdateTitleDto, Title>();
            CreateMap<CreateMissionDto, Mission>();
            CreateMap<UpdateMissionDto, Mission>();
            CreateMap<CreatePermitDto, Permit>();
            CreateMap<UpdatePermitDto, Permit>();
            CreateMap<CreatePhoneCallDto, PhoneCall>();
            CreateMap<UpdatePhoneCallDto, PhoneCall>();
        }
    }
}
