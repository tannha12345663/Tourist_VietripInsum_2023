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
    
    public partial class Ve
    {
        public string MaVe { get; set; }
        public string MaDH { get; set; }
        public string MaLVe { get; set; }
        public string Hoten_KH { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string LuuY { get; set; }
    
        public virtual BookTour BookTour { get; set; }
        public virtual LoaiVe LoaiVe { get; set; }
    }
}
