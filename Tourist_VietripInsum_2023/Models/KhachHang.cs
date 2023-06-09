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
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.BookTours = new HashSet<BookTour>();
            this.PhanHois = new HashSet<PhanHoi>();
        }
    
        public string MaKH { get; set; }
        public string SDT { get; set; }
        public string MaLoaiKH { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string HoTenKH { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string HinhDaiDien { get; set; }
        public Nullable<double> TongTienDat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookTour> BookTours { get; set; }
        public virtual LoaiKH LoaiKH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanHoi> PhanHois { get; set; }
    }
}
