//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SinemaOdev.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satis()
        {
            this.Bilet = new HashSet<Bilet>();
        }
    
        public int SatisID { get; set; }
        public Nullable<int> CalisanID { get; set; }
        public Nullable<System.DateTime> SatisTarih { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilet> Bilet { get; set; }
        public virtual Calisan Calisan { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
