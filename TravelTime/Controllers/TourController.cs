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
            if (entity.PROGRAM_ID == 0 && entity.PROGRAM != null)
            {
                new Repository<PROGRAM>().Add(new PROGRAM() { DETAILS = entity.PROGRAM.DETAILS});
            }
            return base.Add(entity);
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
    }
}
