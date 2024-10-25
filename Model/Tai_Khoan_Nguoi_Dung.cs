namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tai_Khoan_Nguoi_Dung
    {
        [Key]
        [StringLength(10)]
        public string MaTKND { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQTC { get; set; }

        public virtual Quyen_Truy_Cap Quyen_Truy_Cap { get; set; }

        public virtual Sinh_Vien Sinh_Vien { get; set; }
    }
}
