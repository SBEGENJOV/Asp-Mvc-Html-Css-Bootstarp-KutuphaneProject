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
    
    public partial class Kitap
    {
        public int kitapID { get; set; }
        public string kitapAd { get; set; }
        public string kitapYazar { get; set; }
        public string kitapBasin { get; set; }
        public Nullable<int> kitapSayfa { get; set; }
        public Nullable<bool> kitapDurum { get; set; }
        public Nullable<int> kutuphaneID { get; set; }
    
        public virtual Kutuphane Kutuphane { get; set; }
    }
}