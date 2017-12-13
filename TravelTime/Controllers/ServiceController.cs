﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelTime.Models;
using TravelTime.Repositories;

namespace TravelTime.Controllers
{
    public class ServiceController : BaseController<SERVICEPROVIDER>
    {
        public ServiceController(IRepository<SERVICEPROVIDER> Repository) : base(Repository)
        {

        }
    }
}