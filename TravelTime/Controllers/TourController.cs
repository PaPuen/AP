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
    public class TourController : BaseController<TOUR>
    {
        public TourController(IRepository<TOUR> Repository) : base(Repository)
        {
        }
        public override TOUR Add(TOUR entity)
        {
            return base.Add(entity);
        }
        public override ResultApiBase Get(decimal id)
        {
            var e = Repostory.Find(id);
            var result = new TourApiResult()
            {
                Departure = e.DEPARTURE.DESCRIPTION,
                ID = e.ID,
                Name = e.NAME,
                Description = e.DESCRIPTION == null ? String.Empty : e.DESCRIPTION,
                Programe = e.PROGRAM.DETAILS,
                Destination = e.DESTINATION.NAME,
                From = e.FROM == null ? string.Empty : e.FROM.Value.ToString("MM/dd/yyyy"),
                To = e.TO == null ? string.Empty : e.TO.Value.ToString("MM/dd/yyyy"),
                Price = e.PRICE
            };
            return result;
        }
        public override ResultApiBase[] GetAll()
        {
            var data = Repostory.SelectAll();
            var result = data.Select(e => new TourApiResult()
            {
                Departure = e.DEPARTURE.DESCRIPTION,
                ID = e.ID,
                Name = e.NAME,
                Description = e.DESCRIPTION == null ? String.Empty : e.DESCRIPTION,
                Programe = e.PROGRAM.DETAILS,
                Destination = e.DESTINATION.NAME,
                From = e.FROM == null ? string.Empty : e.FROM.Value.ToString("MM/dd/yyyy"),
                To = e.TO == null ? string.Empty : e.TO.Value.ToString("MM/dd/yyyy"),
                Price = e.PRICE
            }).ToArray();
            return result;
        }
        public override ResultApiBase[] HotTours()
        {
            var data = Repostory.SelectAll();
            var result = data.GetRange(0, 3).Select(e => new HotTourResult()
            {
                ID = e.ID,
                Name = e.NAME,
                Description = e.DESCRIPTION == null ? String.Empty : e.DESCRIPTION,
                Destination = e.DESTINATION.NAME,
                From = e.FROM == null ? string.Empty : e.FROM.Value.ToString("MM/dd/yyyy"),
                PhotoUrl = e.TRANSPORT.MOREINFO
            }).ToArray();
            return result;
        }
    }
}
