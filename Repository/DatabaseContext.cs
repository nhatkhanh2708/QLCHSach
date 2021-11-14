using Microsoft.EntityFrameworkCore;
using Model.Entities.Sach;
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=QLCHSach;Trusted_Connection=True");
        }*/

        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<SachTacGia> SachTacGias { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<SachTheLoai> SachTheLoais { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<LichSuGia> LichSuGias { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // 1 NXB - n Sach
            #region
            builder.Entity<Sach>()
                .HasOne<NhaXuatBan>(s => s.Nxb)
                .WithMany(s => s.Sachs)
                .HasForeignKey(s => s.NxbId);
            #endregion

            // n Sach - n The Loai
            #region
            builder.Entity<SachTheLoai>()
                .HasOne<Sach>(s => s.Sach)
                .WithMany(s => s.SachTheLoais)
                .HasForeignKey(s => s.SachId);

            builder.Entity<SachTheLoai>()
                .HasOne<TheLoai>(s => s.TheLoai)
                .WithMany(s => s.SachTheLoais)
                .HasForeignKey(s => s.TheLoaiId);
            #endregion

            // n Sach - n Tac Gia
            #region
            builder.Entity<SachTacGia>()
                .HasOne<Sach>(s => s.Sach)
                .WithMany(s => s.SachTacGias)
                .HasForeignKey(s => s.SachId);

            builder.Entity<SachTacGia>()
                .HasOne<TacGia>(s => s.TacGia)
                .WithMany(s => s.SachTacGias)
                .HasForeignKey(s => s.TacGiaId);
            #endregion

            // 1 Sach - n Lich Su Gia
            #region
            builder.Entity<LichSuGia>()
                .HasOne<Sach>(s => s.Sach)
                .WithMany(s => s.LichSuGias)
                .HasForeignKey(s => s.SachId);
            #endregion

            // 

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
