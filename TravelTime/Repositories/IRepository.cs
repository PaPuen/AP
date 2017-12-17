using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TravelTime.Models;

namespace TravelTime.Repositories
{
    public interface IRepository<E> where E: EntityBase
    { 
        E Add(E entity);
        E Update(E entity);
        E FindById(Decimal id);
        void Delete(E entity);
        void DeleteWithId(Decimal id);
        IList<E> SelectAll();
        IList<E> SelectAll(Expression<Func<E, bool>> expression);
        int GetCount();
        IQueryable<E> Where(Expression<Func<E, bool>> expression);
        int SaveChanges();
    }
}

