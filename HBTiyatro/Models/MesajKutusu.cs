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
    
    public partial class MesajKutusu
    {
        public int MesajID { get; set; }
        public string Baslik { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public string KayitTarihi { get; set; }
        public Nullable<int> KullaniciID { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
    }
}
