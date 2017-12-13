using System.Collections.Generic;
using System.Web.Http;
using TravelTime.Models;
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
            Repostory.Add(entity);
            SaveChanges();
            return entity;
        }
        
        [HttpPut]
        public virtual E Update(E entity)
        {
            Repostory.Update(entity);
            SaveChanges();
            return entity;
        }

        [HttpGet]
        public virtual IList<E> GetAll()
        {
            return Repostory.SelectAll();
        }

        //[HttpGet]
        //public virtual E Find(decimal id)
        //{
        //    return GetAll().Find(e => e.getId() == id);

        //}

        [HttpDelete]
        public void Delete(decimal id)
        {
            Repostory.DeleteWithId(id);
            SaveChanges();
        }

        public virtual void SaveChanges()
        {
            Repostory.SaveChanges();
        }

        [HttpGet]
        public string PING()
        {
            return this.GetType().ToString();
        }
    }
}
