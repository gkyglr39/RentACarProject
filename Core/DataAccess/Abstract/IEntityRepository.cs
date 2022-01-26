using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity: class,IEntity, new()
    {
        void Add(TEntity entity);
        TEntity GetById(int Id);
        List<TEntity> GetAll(Func<TEntity,bool> expression=null);
        void Update(TEntity entity);
        void Delete(int delete);



    }
}
