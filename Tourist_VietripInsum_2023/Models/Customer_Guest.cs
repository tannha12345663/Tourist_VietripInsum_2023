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
    
    public partial class Customer_Guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer_Guest()
        {
            this.OrderCus = new HashSet<OrderCu>();
        }
    
        public string IdCus { get; set; }
        public string NoPhone { get; set; }
        public string IdTypeCus { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public string Fullname { get; set; }
        public string Useraddress { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Gender { get; set; }
    
        public virtual TypeCu TypeCu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCu> OrderCus { get; set; }
    }
}
