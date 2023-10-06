//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kutuphane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kutuphane()
        {
            this.Calisanlar = new HashSet<Calisanlar>();
            this.Calisma = new HashSet<Calisma>();
            this.Kitap = new HashSet<Kitap>();
            this.Ogrenciler = new HashSet<Ogrenciler>();
        }
    
        public int kutuphaneID { get; set; }
        public string kutuphaneAdi { get; set; }
        public string kutuphaneYonetici { get; set; }
        public Nullable<int> kutuphaneCalKap { get; set; }
        public Nullable<int> kutuphaneBilKap { get; set; }
        public Nullable<int> subeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calisanlar> Calisanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calisma> Calisma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitap> Kitap { get; set; }
        public virtual Sube Sube { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ogrenciler> Ogrenciler { get; set; }
    }
}