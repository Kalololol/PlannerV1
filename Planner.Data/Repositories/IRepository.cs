using Planner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
        void SaveChanges();


    }
}
