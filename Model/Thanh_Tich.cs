namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thanh_Tich
    {
        [Required]
        [StringLength(10)]
        public string MaHDNK { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Key]
        public int MaTT { get; set; }

        public virtual Hoat_Dong_Ngoai_Khoa Hoat_Dong_Ngoai_Khoa { get; set; }

        public virtual Sinh_Vien Sinh_Vien { get; set; }
    }
}
