using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelTime.Models;
using TravelTime.Repositories;

namespace TravelTime.Controllers
{
    public class DestinationController : BaseController<DESTINATION>
    {
        public DestinationController(IRepository<DESTINATION> Repository) : base(Repository)
        {

        }
    }
}
