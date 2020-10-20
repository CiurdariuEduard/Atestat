//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magazin_Virtual
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturi()
        {
            this.PozitiiFacturis = new HashSet<PozitiiFacturi>();
        }
    
        public int Id { get; set; }
        public decimal Total { get; set; }
        public System.DateTime Data { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> Cantitate { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PozitiiFacturi> PozitiiFacturis { get; set; }
    }
}