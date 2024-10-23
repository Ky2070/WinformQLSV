namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietLuuDiem")]
    public partial class ChiTietLuuDiem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaQLD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaPDG { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSV { get; set; }

        public virtual Phieu_Danh_Gia Phieu_Danh_Gia { get; set; }

        public virtual Quan_Ly_Diem Quan_Ly_Diem { get; set; }

        public virtual Sinh_Vien Sinh_Vien { get; set; }
    }
}
