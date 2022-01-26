using Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataAccess.Concrete
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Set<TEntity>();
                addedEntity.Add(entity);
                context.SaveChanges();
            }
        }
        public void Delete(int Id)
        {
            using (var context = new TContext())
            {
                var dbEntity = context.Set<TEntity>();
                var removeEntity = dbEntity.Find(Id);
                dbEntity.Remove(removeEntity);
                context.SaveChanges();
            }
        }
        public List<TEntity> GetAll(Func<TEntity, bool> expression=null)
        {
            using (var context = new TContext())
            {
                return expression==null? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(expression).ToList();            }
        }

       
        public TEntity GetById(int Id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(Id);
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
