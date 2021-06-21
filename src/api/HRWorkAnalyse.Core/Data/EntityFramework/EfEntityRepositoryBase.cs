using HRWorkAnalyse.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace HRWorkAnalyse.Core.Data.EntityFramework
{
    public class EfEntityRepositoryBase<TContext, TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext: DbContext
    {
        private readonly TContext _context;
        public EfEntityRepositoryBase(TContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate = null)
        {
            return _context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null
                ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(predicate).ToList();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = _context.Entry(entity); 
            updatedEntity.State = EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
