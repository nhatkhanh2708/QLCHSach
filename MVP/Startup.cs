using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Model.IRepositories;
using Repository;
using Repository.Repositories;
using Service.IServices;
using Service.Mapping;
using Service.Services;
using System;

namespace Model.Entities
{
    public class Startup
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLCHSach;Integrated Security=True;"));


            //Repositories, services
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));

            services.AddScoped<ISachRepository, SachRepository>();
            services.AddScoped<ISachService, SachService>();

            services.AddScoped<ITheLoaiRepository, TheLoaiRepository>();
            services.AddScoped<ITheLoaiService, TheLoaiService>();

            services.AddScoped<ISachTheLoaiRepository, SachTheLoaiRepository>();
            services.AddScoped<ISachTheLoaiService, SachTheLoaiService>();

            services.AddScoped<ITacGiaRepository, TacGiaRepository>();
            services.AddScoped<ITacGiaService, TacGiaService>();

            services.AddScoped<ISachTacGiaRepository, SachTacGiaRepository>();
            services.AddScoped<ISachTacGiaService, SachTacGiaService>();

            services.AddScoped<INxbRepository, NxbRepository>();
            services.AddScoped<INxbService, NxbService>();

            services.AddScoped<INhanVienRepository, NhanVienRepository>();
            services.AddScoped<INhanVienService, NhanVienService>();

            services.AddScoped<INccRepository, NccRepository>();
            services.AddScoped<INccService, NccService>();

            services.AddScoped<IHdNhapRepository, HdNhapRepository>();
            services.AddScoped<IHdNhapService, HdNhapService>();

            services.AddScoped<ICtNhapRepository, CTNhapRepository>();
            services.AddScoped<ICtNhapService, CtNhapService>();

            services.AddScoped<IHdXuatRepository, HdXuatRepository>();
            services.AddScoped<IHdXuatService, HdXuatService>();

            services.AddScoped<ICtXuatRepository, CTXuatRepository>();
            services.AddScoped<ICtXuatService, CtXuatService>();

            services.AddScoped<ITaiKhoanRepository, TaiKhoanRepository>();
            services.AddScoped<ITaiKhoanService, TaiKhoanService>();

            services.AddScoped<IQuyenRepository, QuyenRepository>();
            services.AddScoped<IQuyenService, QuyenService>();

            services.AddAutoMapper(typeof(AutoMapperConfig).Assembly);

            ServiceProvider = services.BuildServiceProvider();
        }

    }
}
