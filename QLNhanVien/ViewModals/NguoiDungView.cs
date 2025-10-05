using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien.ViewModals
{
     public class NguoiDungView
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
        [DisplayName("Chức Vụ")]
        public string TenChucVu { get; set; }
        [DisplayName("Hệ Số Lương")]
        public Double? HeSoLuong { get; set; }
    }
}
