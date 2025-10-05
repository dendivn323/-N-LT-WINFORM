using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLNhanVien.Modals
{
    public partial class QLNhanVienDBContext : DbContext
    {
        public QLNhanVienDBContext()
            : base("name=QLNhanVienDBContext")
        {
        }

        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
