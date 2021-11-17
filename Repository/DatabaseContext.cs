using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Model.Entities;
using System.Reflection;

namespace Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        // Các table trong database
        #region
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<SachTacGia> SachTacGias { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<SachTheLoai> SachTheLoais { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<Quyen> Quyens { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<ChiTietNhap> ChiTietNhaps { get; set; }
        public DbSet<HoaDonXuat> HoaDonXuats { get; set; }
        public DbSet<ChiTietXuat> ChiTietXuats { get; set; }

        #endregion
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

            // 1 Quyen - n Tai khoan
            #region
            builder.Entity<TaiKhoan>()
                .HasOne<Quyen>(s => s.Quyen)
                .WithMany(s => s.TaiKhoans)
                .HasForeignKey(s => s.QuyenId);
            #endregion

            // 1 NV - 1 Tai Khoan
            #region
            builder.Entity<NhanVien>()
            .HasOne<TaiKhoan>(s => s.TaiKhoan)
            .WithOne(ad => ad.nhanVien)
            .HasForeignKey<TaiKhoan>(ad => ad.NhanVienId);
            #endregion

            // 1 Tai khoan - n HD Nhap
            #region
            builder.Entity<HoaDonNhap>()
                .HasOne<TaiKhoan>(s => s.TaiKhoan)
                .WithMany(s => s.HoaDonNhaps)
                .HasForeignKey(s => s.TaiKhoanId);
            #endregion

            // 1 Tai khoan - n HD Xuat
            #region
            builder.Entity<HoaDonXuat>()
                .HasOne<TaiKhoan>(s => s.TaiKhoan)
                .WithMany(s => s.HoaDonXuats)
                .HasForeignKey(s => s.TaiKhoanId);
            #endregion

            // 1 Ncc - n HD Nhap
            #region
            builder.Entity<HoaDonNhap>()
                .HasOne<NhaCungCap>(s => s.NCC)
                .WithMany(s => s.HoaDonNhaps)
                .HasForeignKey(s => s.NccId);
            #endregion

            // n Sach - n HD Nhap
            #region
            builder.Entity<ChiTietNhap>()
                .HasOne<Sach>(s => s.Sach)
                .WithMany(s => s.ChiTietNhaps)
                .HasForeignKey(s => s.SachId);

            builder.Entity<ChiTietNhap>()
                .HasOne<HoaDonNhap>(s => s.HoaDonNhap)
                .WithMany(s => s.ChiTietNhaps)
                .HasForeignKey(s => s.HdNhapId);
            #endregion

            // n Sach - n HD Xuat
            #region
            builder.Entity<ChiTietXuat>()
                .HasOne<Sach>(s => s.Sach)
                .WithMany(s => s.ChiTietXuats)
                .HasForeignKey(s => s.SachId);

            builder.Entity<ChiTietXuat>()
                .HasOne<HoaDonXuat>(s => s.HoaDonXuat)
                .WithMany(s => s.ChiTietXuats)
                .HasForeignKey(s => s.HdXuatId);
            #endregion

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

    public class DesignTimeDatabaseContext : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=QLCHSach;Trusted_Connection=True");
            return new DatabaseContext(builder.Options);
        }
    }
}
