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
    
    public partial class Ogrenciler
    {
        public int ogrenciID { get; set; }
        public string ogrenciAdSoyad { get; set; }
        public Nullable<System.DateTime> ogrenciYas { get; set; }
        public Nullable<bool> ogrenciDurum { get; set; }
        public Nullable<int> kutuphaneID { get; set; }
        public Nullable<int> masaID { get; set; }
    
        public virtual Calisma Calisma { get; set; }
        public virtual Kutuphane Kutuphane { get; set; }
    }
}