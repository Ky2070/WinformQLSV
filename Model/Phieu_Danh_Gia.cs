namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Phieu_Danh_Gia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Danh_Gia()
        {
            ChiTietLuuDiems = new HashSet<ChiTietLuuDiem>();
            MonHocs = new HashSet<MonHoc>();
        }

        [Key]
        [StringLength(10)]
        public string MaPDG { get; set; }

        [StringLength(20)]
        public string XepLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLuuDiem> ChiTietLuuDiems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }
}
