namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sinh_Vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sinh_Vien()
        {
            ChiTietLuuDiems = new HashSet<ChiTietLuuDiem>();
            Tai_Khoan_Nguoi_Dung = new HashSet<Tai_Khoan_Nguoi_Dung>();
            Tai_lIeu = new HashSet<Tai_lIeu>();
            Hoat_Dong_Ngoai_Khoa = new HashSet<Hoat_Dong_Ngoai_Khoa>();
        }

        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(15)]
        public string MaLop { get; set; }

        [StringLength(50)]
        public string HoTenSV { get; set; }

        [StringLength(6)]
        public string Phai { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string Khoa { get; set; }

        [StringLength(20)]
        public string TrangThaiSV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLuuDiem> ChiTietLuuDiems { get; set; }

        public virtual Lop Lop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tai_Khoan_Nguoi_Dung> Tai_Khoan_Nguoi_Dung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tai_lIeu> Tai_lIeu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hoat_Dong_Ngoai_Khoa> Hoat_Dong_Ngoai_Khoa { get; set; }

    }
}
