//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tourist_VietripInsum_2023.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietTour
    {
        public string MaCTT { get; set; }
        public int STT { get; set; }
        public string MaTour { get; set; }
        public string MaPTien { get; set; }
        public string TieuDe { get; set; }
        public string MotaChitiet { get; set; }
        public string MaDDTQ { get; set; }
    
        public virtual DiaDiemThamQuan DiaDiemThamQuan { get; set; }
        public virtual PhuongTien PhuongTien { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
