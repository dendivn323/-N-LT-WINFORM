using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.Data
{
    public partial class QLNVDbContext : DbContext
    {
        public QLNVDbContext()
            : base("name=QLNVDbContext")
        {
        }

        public virtual DbSet<ChucVu> ChucVu { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
