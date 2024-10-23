namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [Key]
        [StringLength(10)]
        public string MaMH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGV { get; set; }

        [StringLength(50)]
        public string TenMH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPDG { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQLD { get; set; }

        public DateTime? ThoiGianHoc { get; set; }

        [StringLength(20)]
        public string TrangThaiMH { get; set; }

        public virtual Giao_Vien Giao_Vien { get; set; }

        public virtual Khoa Khoa { get; set; }

        public virtual Phieu_Danh_Gia Phieu_Danh_Gia { get; set; }

        public virtual Quan_Ly_Diem Quan_Ly_Diem { get; set; }
    }
}
