using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTime.Models.CustomModels
{
    public class TourApiResult : ResultApiBase
    {
        public decimal ID { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }

        public string Departure { get; set; }
        public string Programe { get; set; }
        public string Destination { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}