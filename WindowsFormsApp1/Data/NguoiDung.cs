namespace WindowsFormsApp1.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        [StringLength(50)]
        public string MaNguoiDung { get; set; }

        [StringLength(250)]
        public string HoTen { get; set; }

        [StringLength(250)]
        public string MatKhau { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string MaChucVu { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
