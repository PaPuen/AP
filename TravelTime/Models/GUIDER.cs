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

    public partial class GUIDER : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GUIDER()
        {
            this.TOURs = new HashSet<TOUR>();
        }
    
        public decimal GUIDER_ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> AGE { get; set; }
        public Nullable<decimal> PERSONALID { get; set; }
        public string GENDER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOUR> TOURs { get; set; }

        public override decimal getId()
        {
            throw new NotImplementedException();
        }
    }
}
