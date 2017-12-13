using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTime.Models
{
    public abstract class EntityBase
    {
        public EntityBase() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id;
        public decimal getId() { return this.id; }
    }
}