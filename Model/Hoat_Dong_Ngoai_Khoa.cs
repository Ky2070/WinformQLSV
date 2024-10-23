namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hoat_Dong_Ngoai_Khoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoat_Dong_Ngoai_Khoa()
        {
            Sinh_Vien = new HashSet<Sinh_Vien>();
        }

        [Key]
        [StringLength(10)]
        public string MaHDNK { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQTV { get; set; }

        [StringLength(50)]
        public string TenHDNK { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public virtual Quan_Tri_Vien Quan_Tri_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinh_Vien> Sinh_Vien { get; set; }
    }
}
