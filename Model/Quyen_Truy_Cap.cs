namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quyen_Truy_Cap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quyen_Truy_Cap()
        {
            Giao_Vien = new HashSet<Giao_Vien>();
            Tai_Khoan_Nguoi_Dung = new HashSet<Tai_Khoan_Nguoi_Dung>();
        }

        [Key]
        [StringLength(10)]
        public string MaQTC { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQTV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Giao_Vien> Giao_Vien { get; set; }

        public virtual Quan_Tri_Vien Quan_Tri_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tai_Khoan_Nguoi_Dung> Tai_Khoan_Nguoi_Dung { get; set; }
    }
}
