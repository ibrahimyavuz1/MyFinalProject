using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //Class: Reference Type
    //IEntity: It can be IEntity or a object that implement IEntity.
    //new(): It should be renewable(Parameter must be construct)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); // used to filter.
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity); // Interface methods are public as default.  
        void Update(T entity);
        void Delete(T entity);
    }
}
