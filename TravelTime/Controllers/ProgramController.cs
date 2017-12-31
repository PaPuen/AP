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
    public class ProgramController :  BaseController<PROGRAM>
    {
        public ProgramController(IRepository<PROGRAM> Repository) : base(Repository)
        {

        }

        public override ResultApiBase[] GetAll()
        {
            var data = Repostory.SelectAll();
            var result = data.Select(e => new ProgramApiResult()
            {
                Id = e.ID,
                Details = e.DETAILS
            }).ToArray();
            return result;
        }
        public override ResultApiBase[] HotTours()
        {
            throw new NotImplementedException();
        }
    }
}
