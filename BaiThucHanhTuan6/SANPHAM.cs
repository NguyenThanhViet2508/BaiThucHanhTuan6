//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiThucHanhTuan6
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.CTHDs = new HashSet<CTHD>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string DonVi { get; set; }
        public Nullable<double> DonGia { get; set; }
        public string MaNSX { get; set; }
        public Nullable<double> GiaGoc { get; set; }
        public Nullable<int> MaLoai { get; set; }
        public byte[] HinhSP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
        public virtual LOAISP LOAISP { get; set; }
        public virtual NSX NSX { get; set; }
    }
}
