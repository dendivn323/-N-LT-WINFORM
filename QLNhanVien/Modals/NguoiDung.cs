namespace QLNhanVien.Modals
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        [StringLength(50)]
        [DisplayName("Mã Người Dùng")]
        public string MaNguoiDung { get; set; }

        [StringLength(250)]
        [DisplayName("Họ Tên")]
        public string HoTen { get; set; }

        [StringLength(250)]
        [DisplayName("Mật Khẩu")]
        public string MatKhau { get; set; }

        [StringLength(20)]
        [DisplayName("SĐT")]
        public string SDT { get; set; }

        [StringLength(50)]
        [Display(AutoGenerateField = false)]
        public string MaChucVu { get; set; }

        [Display(AutoGenerateField = false)]
        public virtual ChucVu ChucVu { get; set; }

    }
}
