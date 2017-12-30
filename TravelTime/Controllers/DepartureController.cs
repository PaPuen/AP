using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelTime.Models;
using TravelTime.Models.CustomModels;
using TravelTime.Repositories;

namespace TravelTime.Controllers
{
    public class DepartureController : BaseController<DEPARTURE>
    {
        public DepartureController(IRepository<DEPARTURE> Repository) : base(Repository)
        {

        }

        public override ResultApiBase[] GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
