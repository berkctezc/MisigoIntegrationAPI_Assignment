using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //tekrarlayan interfaceleri ortak bir interface icerisine yerlestirdik

    //generic constraint
    //class: referans tip olabilir anlamına gelmekte!
    //IEntity: IEntity veya IEntity implement eden bir nesne olabilir
    //new(): newlenebilir olmalı (IEntity olamayacak)
    public interface IEntityRepository<T> where T :class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
