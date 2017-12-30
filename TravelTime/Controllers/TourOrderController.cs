using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelTime.Models;
using TravelTime.Repositories;
using TravelTime.Models.CustomModels;

namespace TravelTime.Controllers
{
    public class TourOrderController : BaseController<TOURORDER>
    {
        public TourOrderController(IRepository<TOURORDER> Repository) : base(Repository)
        {

        }
        public override TOURORDER Add(TOURORDER entity)
        {
            entity.DATE = DateTime.Now;
            return base.Add(entity);
        }

        public override ResultApiBase[] GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
