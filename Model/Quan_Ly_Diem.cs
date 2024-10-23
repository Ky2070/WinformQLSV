namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quan_Ly_Diem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quan_Ly_Diem()
        {
            ChiTietLuuDiems = new HashSet<ChiTietLuuDiem>();
            MonHocs = new HashSet<MonHoc>();
        }

        [Key]
        [StringLength(10)]
        public string MaQLD { get; set; }

        public double? Diem { get; set; }

        [StringLength(18)]
        public string KetQuaHocTap { get; set; }

        [StringLength(20)]
        public string TrangThaiDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLuuDiem> ChiTietLuuDiems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }
}
