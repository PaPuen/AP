//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelTime.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CUSTOMER : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.TICKETs = new HashSet<TICKET>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CUSTOMER_ID { get; set; }
        public Nullable<decimal> ORDER_ID { get; set; }
        public string NAME { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
    
        public virtual TOURORDER TOURORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TICKET> TICKETs { get; set; }

        public override decimal getId()
        {
            return CUSTOMER_ID;
        }
    }
}