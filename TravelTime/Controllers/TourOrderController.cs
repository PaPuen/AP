using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TravelTime.Models;
using TravelTime.Repositories;
using TravelTime.Models.CustomModels;

namespace TravelTime.Controllers
{
    public class TourOrderController : BaseController<TOURORDER>
    {
        public TourOrderController(IRepository<TOURORDER> Repository) : base(Repository)
        {

        }
        public override TOURORDER Add(TOURORDER entity)
        {
            entity.DATE = DateTime.Now;
            entity.STATUS = 0;
            return base.Add(entity);
        }

        public override TOURORDER DoneOrder(decimal id)
        {
            var order = Find(id);
            order.STATUS = 1;
            GenerateTicket(order);
            return Update(order);
        }

        public void GenerateTicket(TOURORDER order) {
            Repostory.GenerateTicket(order);
        }

        public override ResultApiBase[] GetAll()
        {
            var data = Repostory.SelectAll();
            List<OrderResult> result = new List<OrderResult>();
            foreach (TOURORDER e in data)
            {
               var a = new OrderResult()
                {
                    ID = e.ID,
                    TourId = e.TOUR_ID,
                    OrderDate = e.DATE==null ? string.Empty : e.DATE.Value.ToString("MM/dd/yyyy"),
                    Total = e.TOTALAMOUNT ?? e.TOUR.PRICE,
                    NumOfPeople = e.NUMOFPEOPLE ?? 1,
                    Status = e.STATUS ?? 0,
                    CustomerId = e.CUSTOMERs.Count > 0 ? e.CUSTOMERs.FirstOrDefault().ID : 0,
                    CustomerName = e.CUSTOMERs.Count > 0 ? e.CUSTOMERs.FirstOrDefault().NAME.Trim() : String.Empty
                };
               result.Add(a);
            }
            //var result = data.Select(e => new OrderResult()
            //{
            //    ID = e.ID,
            //    TourId = e.TOUR_ID,
            //    OrderDate = e.DATE==null ? string.Empty : e.DATE.Value.ToString("MM/dd/yyyy"),
            //    Total = e.TOTALAMOUNT ?? e.TOUR.PRICE,
            //    NumOfPeople = e.NUMOFPEOPLE ?? 1,
            //    Status = e.STATUS ?? 0,
            //    CustomerId = e.CUSTOMERs.Count > 0 ? e.CUSTOMERs.FirstOrDefault().ID : 0,
            //    CustomerName = e.CUSTOMERs.Count > 0 ? e.CUSTOMERs.FirstOrDefault().NAME.Trim() : String.Empty
            //});

            return result.ToArray();
        }

        public override ResultApiBase[] HotTours()
        {
            throw new NotImplementedException();
        }
        
    }
}
