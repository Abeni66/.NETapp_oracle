//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISTODB_application3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TORGOVAJA_TOCHKA
    {
        public TORGOVAJA_TOCHKA()
        {
            this.CENY_TOCHKI = new HashSet<CENY_TOCHKI>();
            this.NOMENKLTR_TCHK = new HashSet<NOMENKLTR_TCHK>();
            this.UNIVERMAG = new HashSet<UNIVERMAG>();
        }
    
        public long ID { get; set; }
        public string IMJA_TORG_TOCHKI { get; set; }
    
        public virtual ICollection<CENY_TOCHKI> CENY_TOCHKI { get; set; }
        public virtual ICollection<NOMENKLTR_TCHK> NOMENKLTR_TCHK { get; set; }
        public virtual ICollection<UNIVERMAG> UNIVERMAG { get; set; }
    }
}