using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTime.Models.CustomModels
{
    public class ProgramApiResult : ResultApiBase
    {
        public decimal Id { get; set; }
       
        public string Details { get; set; }
    }
}