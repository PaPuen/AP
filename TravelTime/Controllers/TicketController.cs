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
    public class TicketController : BaseController<TICKET>
    {
        public TicketController(IRepository<TICKET> Repository) : base(Repository)
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
        public override List<TICKET> Where(decimal id) {
            return Repostory.SelectAll().Where(e => e.CUSTOMER_ID == id).ToList();
        }
    }
}
