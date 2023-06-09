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
    
    public partial class BookTour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookTour()
        {
            this.Ves = new HashSet<Ve>();
        }
    
        public string MaDH { get; set; }
        public string MaNVLap { get; set; }
        public string MaTour { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<bool> TrangThaiTT { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public Nullable<int> SoCho { get; set; }
        public string SdtKH { get; set; }
        public string MaKH { get; set; }
        public Nullable<bool> HinhThucThanhToan { get; set; }
        public Nullable<bool> XacNhanDH { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Tour Tour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
