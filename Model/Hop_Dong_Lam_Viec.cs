namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hop_Dong_Lam_Viec
    {
        [Key]
        [StringLength(10)]
        public string MaHopDong { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetthuc { get; set; }

        [StringLength(50)]
        public string DieuKhoan { get; set; }

        [Column(TypeName = "money")]
        public decimal? MucLuong { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQTV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGV { get; set; }

        public virtual Giao_Vien Giao_Vien { get; set; }

        public virtual Quan_Tri_Vien Quan_Tri_Vien { get; set; }
    }
}
