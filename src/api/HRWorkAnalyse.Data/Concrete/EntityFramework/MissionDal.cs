﻿using HRWorkAnalyse.Core.Data.EntityFramework;
using HRWorkAnalyse.Data.Abstract;
using HRWorkAnalyse.Data.DbContexts;
using HRWorkAnalyse.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRWorkAnalyse.Data.Concrete.EntityFramework
{
    public class MissionDal: EfEntityRepositoryBase<HrWorkAnalyseDbContext, Mission>, IMissionDal
    {
        public MissionDal(HrWorkAnalyseDbContext context):base(context)
        {

        }
    }
}
