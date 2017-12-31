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
    public class ServiceController : BaseController<SERVICEPROVIDER>
    {
        public ServiceController(IRepository<SERVICEPROVIDER> Repository) : base(Repository)
        {

        }

        public override ResultApiBase[] GetAll()
        {
            throw new NotImplementedException();
        }
        public override ResultApiBase[] HotTours()
        {
            throw new NotImplementedException();
        }
    }
}
