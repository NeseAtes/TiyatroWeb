//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HBTiyatro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oyuncular
    {
        public int OyuncuId { get; set; }
        public string OyuncuAdi { get; set; }
        public string OyuncuResimLinki { get; set; }
        public Nullable<int> OyunID { get; set; }
        public string OyuncuSoyadi { get; set; }
        public string Yazar { get; set; }
        public string Yonetmen { get; set; }
        public string Ceviren { get; set; }
        public string Muzik { get; set; }
    
        public virtual Oyunlar Oyunlar { get; set; }
    }
}
