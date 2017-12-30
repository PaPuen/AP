using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using TravelTime.Models;
using System.Linq;

namespace TravelTime.Repositories
{
    public class Repository<E> : IRepository<E> 
    where E : EntityBase
    {
        private TravelTimeEDM_Entities dbcontext;
        private DbSet<E> dbSet;

        public Repository()
        {
            dbcontext = dbcontext ?? new TravelTimeEDM_Entities();
            dbSet = dbcontext.Set<E>();
        }


        public E Add(E entity)
        {
            return dbSet.Add(entity);
        }

        public E Delete(decimal id)
        {
            var obj = dbSet.Find(id);
            return dbSet.Remove(obj);
        }

        public int GetCount()
        {
            return dbSet.Count();
        }

        public int SaveChanges()
        {
            return dbcontext.SaveChanges();
        }

        public List<E> SelectAll()
        {
            return dbSet.ToList();
        }

        public List<E> SelectWithoutEager()
        {
            dbcontext.Configuration.LazyLoadingEnabled = false;
            return dbSet.ToList();
        }

        public List<E> SelectAll(Expression<Func<E, bool>> expression)
        {
            return this.Where(expression).ToList();
        }

        public E Update(E entity)
        {
            var obj = dbSet.Attach(entity);
            dbcontext.Entry(entity).State = EntityState.Modified;
            return obj;
        }

        public List<E> Where(Expression<Func<E, bool>> expression)
        {
            return dbSet.Where(expression).ToList();
        }

        public E Find(decimal id)
        {
            return dbSet.Find(id);
        }
    }
}