using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic constraint
    //class : T referans tip olabilir demek "where T:class"
    //,IEntity : IEntity olabilir veya ondan implemente edilmiş bir nesne olabilir
    //new() newlenebilir olmalı IEntity newlenemez yani T entitiesteki nesneleri referans alabilir
  public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        
    }
}
