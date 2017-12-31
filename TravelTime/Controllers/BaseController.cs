using System;
using System.Collections.Generic;
using System.Web.Http;
using TravelTime.Models;
using TravelTime.Models.CustomModels;
using TravelTime.Repositories;

namespace TravelTime.Controllers
{
    public abstract class BaseController<E> : ApiController where E : EntityBase
    {
        protected readonly IRepository<E> Repostory;
        public BaseController(IRepository<E> repository)
        {
            this.Repostory = repository;
        }

        [HttpPost]
        public virtual E Add(E entity)
        {
            var obj = Repostory.Add(entity);
            SaveChanges();
            return obj;
        }

        [HttpPost]
        public virtual List<E> AddCustomers(IList<E> entites)
        {
            var res = new List<E>();
            foreach (E entity in entites)
            {
                var obj = Repostory.Add(entity);
                SaveChanges();
                res.Add(obj);
            }
            return res;
        }

        [HttpGet]
        public virtual E Find(decimal id)
        {
            return Repostory.Find(id);
        }

        [HttpPost]
        public virtual E Update(E entity)
        {
            var obj = Repostory.Update(entity);
            SaveChanges();
            return obj;
        }

        [HttpPost]
        public abstract ResultApiBase[] GetAll();

        [HttpGet]
        public virtual ResultApiBase Get(decimal id)
        {
            return null;
        }

        [HttpPost]
        public abstract ResultApiBase[] HotTours();
      
        [HttpGet]
        public virtual List<E> SelectWithoutEager()
        {
            return Repostory.SelectWithoutEager();
        }

        [HttpDelete]
        public E Delete(decimal id)
        {
            var obj = Repostory.Delete(id);
            SaveChanges();
            return obj;
        }

        public virtual void SaveChanges()
        {
            Repostory.SaveChanges();
        }
        
    }
}
