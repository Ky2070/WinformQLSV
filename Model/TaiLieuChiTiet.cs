namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiLieuChiTiet")]
    public partial class TaiLieuChiTiet
    {
        [Required]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTL { get; set; }

        [Key]
        public int MaTLCT { get; set; }

        public virtual Sinh_Vien Sinh_Vien { get; set; }

        public virtual Tai_lIeu Tai_lIeu { get; set; }
    }
}
