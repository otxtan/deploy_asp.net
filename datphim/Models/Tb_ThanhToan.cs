//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace datphim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_ThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_ThanhToan()
        {
            this.Tb_HoaDon = new HashSet<Tb_HoaDon>();
        }
    
        public long Ma_TT { get; set; }
        public string TenTiengViet { get; set; }
        public string TenNguoiNhan { get; set; }
        public string SoTaiKhoan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_HoaDon> Tb_HoaDon { get; set; }
    }
}
