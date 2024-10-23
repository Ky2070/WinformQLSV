namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quan_Ly_Cap_Cao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Quan_Ly_Cap_Cao()
        {
            Quan_Tri_Vien = new HashSet<Quan_Tri_Vien>();
        }

        [Key]
        [StringLength(10)]
        public string MaQLCC { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [StringLength(40)]
        public string HoTen { get; set; }

        [StringLength(6)]
        public string Phai { get; set; }

        [StringLength(20)]
        public string BangCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quan_Tri_Vien> Quan_Tri_Vien { get; set; }
    }
}
