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

    public partial class TOURORDER : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOURORDER()
        {
            this.CUSTOMERs = new HashSet<CUSTOMER>();
        }
    
        public decimal ID { get; set; }
        public decimal TOUR_ID { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<int> NUMOFPEOPLE { get; set; }
        public Nullable<double> TOTALAMOUNT { get; set; }
        public Nullable<int> STATUS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMERs { get; set; }
        public virtual TOUR TOUR { get; set; }
    }
}
