namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChucVu")]
    public partial class ChucVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChucVu()
        {
            NguoiDung = new HashSet<NguoiDung>();
        }

        [Key]
        [StringLength(50)]
        public string MaChucVu { get; set; }

        [StringLength(250)]
        public string TenChucVu { get; set; }

        public double? HeSoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
    }
}
