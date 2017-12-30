using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TravelTime.Models;

namespace TravelTime.Repositories
{
    public interface IRepository<E> where E: EntityBase
    { 
        E Add(E entity);
        E Update(E entity);
        E Find(Decimal id);
        E Delete(Decimal id);
        List<E> SelectAll();
        List<E> SelectWithoutEager();
        List<E> SelectAll(Expression<Func<E, bool>> expression);
        int GetCount();
        List<E> Where(Expression<Func<E, bool>> expression);
        int SaveChanges();
        
    }
}

