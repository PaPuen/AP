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
            dbSet.Add(entity);
            return entity;
        }

        public void Delete(E entity)
        {
            dbSet.Remove(entity);
        }

        public void DeleteWithId(decimal id)
        {
            var e = dbSet.First(o => o.id == id);
            if (e != null) { dbSet.Remove(e); }
        }

        public int GetCount()
        {
            return dbSet.Count();
        }

        public int SaveChanges()
        {
            return dbcontext.SaveChanges();
        }

        public IList<E> SelectAll()
        {
            return dbSet.ToList();
        }

        public IList<E> SelectAll(Expression<Func<E, bool>> expression)
        {
            return this.Where(expression).ToList();
        }

        public E Update(E entity)
        {
            dbSet.Attach(entity);
            return entity;
        }

        public IQueryable<E> Where(Expression<Func<E, bool>> expression)
        {
            return dbSet.Where(expression);
        }
    }
}