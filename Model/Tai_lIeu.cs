namespace QLMH.DangDuyHoang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tai_lIeu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tai_lIeu()
        {
            Sinh_Vien = new HashSet<Sinh_Vien>();
        }

        [Key]
        [StringLength(20)]
        public string MaTL { get; set; }

        [StringLength(50)]
        public string TenTL { get; set; }

        [StringLength(10)]
        public string LoaiTL { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGV { get; set; }

        public virtual Giao_Vien Giao_Vien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sinh_Vien> Sinh_Vien { get; set; }
    }
}
