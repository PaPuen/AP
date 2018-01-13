using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTime.Models.CustomModels
{
    public class OrderResult : ResultApiBase
    {
        public decimal ID { get; set; }
        public decimal TourId { get; set; }
        public string OrderDate { get; set; }
        public double? Total { get; set; }
        public int NumOfPeople { get; set; }
        public int Status { get; set; }
        public string CustomerName { get; set; }
        public decimal CustomerId { get; set; }
    }
}