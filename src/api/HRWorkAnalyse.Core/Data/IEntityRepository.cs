﻿using HRWorkAnalyse.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace HRWorkAnalyse.Core.Data
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> predicate = null);
        T Get(Expression<Func<T,bool>> predicate = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
