using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTime.Models;
using TravelTime.Repositories;

namespace TravelTime.Repository
{
    public class RepositoryBase
    {
        public TravelTimeEDM_Entities DataModel
        {
            get
            {
                return DataModel ?? new TravelTimeEDM_Entities();
            }
        }

    }
}