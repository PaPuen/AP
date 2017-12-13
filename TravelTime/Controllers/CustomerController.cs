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
    public class CustomerController : BaseController<CUSTOMER>
    {
        public CustomerController(IRepository<CUSTOMER> Repository) : base(Repository)
        {
           
        }
        public override CUSTOMER Add(CUSTOMER entity)
        {
            //entity.CUSTOMER_ID = new Random().Next(50, 100000);

            return base.Add(entity);
        }
    }
}