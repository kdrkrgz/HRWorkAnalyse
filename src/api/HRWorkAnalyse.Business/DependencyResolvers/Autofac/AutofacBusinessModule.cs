using Autofac;
using HRWorkAnalyse.Business.Abstract;
using HRWorkAnalyse.Business.Concrete;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using HRWorkAnalyse.Business.Mappings.AutoMapper;

namespace HRWorkAnalyse.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Repos
            builder.RegisterType<CompanyDal>().As<ICompanyDal>().InstancePerLifetimeScope();
            builder.RegisterType<DepartmentDal>().As<IDepartmentDal>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeDal>().As<IEmployeeDal>().InstancePerLifetimeScope();
            builder.RegisterType<MissionDal>().As<IMissionDal>().InstancePerLifetimeScope();
            builder.RegisterType<PermitDal>().As<IPermitDal>().InstancePerLifetimeScope();
            builder.RegisterType<PhoneCallDal>().As<IPhoneCallDal>().InstancePerLifetimeScope();
            builder.RegisterType<TitleDal>().As<ITitleDal>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyUserDal>().As<ICompanyUserDal>().InstancePerLifetimeScope();

            // BusinessManagers
            builder.RegisterType<CompanyManager>().As<ICompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().InstancePerLifetimeScope();
            builder.RegisterType<TitleManager>().As<ITitleService>().InstancePerLifetimeScope();
            builder.RegisterType<MissionManager>().As<IMissionService>().InstancePerLifetimeScope();
            builder.RegisterType<PermitManager>().As<IPermitService>().InstancePerLifetimeScope();
            builder.RegisterType<PhoneCallManager>().As<IPhoneCallService>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyUserManager>().As<ICompanyUserService>().InstancePerLifetimeScope();
            builder.RegisterType<AutoMapperProfile>().SingleInstance();
        }
    }
}
