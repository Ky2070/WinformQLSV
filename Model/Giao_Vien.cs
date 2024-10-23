namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Giao_Vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giao_Vien()
        {
            Hop_Dong_Lam_Viec = new HashSet<Hop_Dong_Lam_Viec>();
            MonHocs = new HashSet<MonHoc>();
            Tai_lIeu = new HashSet<Tai_lIeu>();
        }

        [Key]
        [StringLength(10)]
        public string MaGV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQTV { get; set; }

        [StringLength(50)]
        public string HoTenGV { get; set; }

        [StringLength(6)]
        public string Phai { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10)]
        public string MaQTC { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [StringLength(50)]
        public string BangCap { get; set; }

        [StringLength(20)]
        public string TrangThaiGV { get; set; }

        public virtual Khoa Khoa { get; set; }

        public virtual Quyen_Truy_Cap Quyen_Truy_Cap { get; set; }

        public virtual Quan_Tri_Vien Quan_Tri_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hop_Dong_Lam_Viec> Hop_Dong_Lam_Viec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonHoc> MonHocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tai_lIeu> Tai_lIeu { get; set; }
    }
}
