namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quan_Tri_Vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quan_Tri_Vien()
        {
            Giao_Vien = new HashSet<Giao_Vien>();
            Hoat_Dong_Ngoai_Khoa = new HashSet<Hoat_Dong_Ngoai_Khoa>();
            Hop_Dong_Lam_Viec = new HashSet<Hop_Dong_Lam_Viec>();
            Quyen_Truy_Cap = new HashSet<Quyen_Truy_Cap>();
        }

        [Key]
        [StringLength(10)]
        public string MaQTV { get; set; }

        [StringLength(50)]
        public string HoTenQTV { get; set; }

        [StringLength(6)]
        public string Phai { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [StringLength(15)]
        public string BangCap { get; set; }

        public DateTime? NgayBatDauLamViec { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQLCC { get; set; }

        [StringLength(20)]
        public string TrangThaiQTV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Giao_Vien> Giao_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoat_Dong_Ngoai_Khoa> Hoat_Dong_Ngoai_Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hop_Dong_Lam_Viec> Hop_Dong_Lam_Viec { get; set; }

        public virtual Quan_Ly_Cap_Cao Quan_Ly_Cap_Cao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quyen_Truy_Cap> Quyen_Truy_Cap { get; set; }
    }
}
