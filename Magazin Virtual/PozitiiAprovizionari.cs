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
    
    public partial class PozitiiAprovizionari
    {
        public int Id { get; set; }
        public int AprovizionareId { get; set; }
        public int ProdusId { get; set; }
        public Nullable<int> Cantitate { get; set; }
        public decimal PretPerBuc { get; set; }
        public decimal PretTotal { get; set; }
        public int LocationId { get; set; }
    
        public virtual Aprovizionari Aprovizionari { get; set; }
        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
