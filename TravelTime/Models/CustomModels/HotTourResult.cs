using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTime.Models.CustomModels
{
    public class HotTourResult : ResultApiBase
    {
        public decimal ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }
        public string From { get; set; }
        public string PhotoUrl { get; set; }
    }
}