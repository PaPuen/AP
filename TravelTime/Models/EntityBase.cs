using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTime.Models
{
    public abstract class EntityBase
    {
        public EntityBase() { }
        public decimal id { get { return this.getId(); } }
        public abstract decimal getId();
    }
}