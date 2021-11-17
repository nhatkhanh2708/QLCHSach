using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Model.IRepositories;
using Model.IRepositories.ISachRepositories;
using Repository;
using Repository.Repositories;
using Repository.Repositories.SachRepositories;
using Service.IServices.ISachServices;
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

            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));

            services.AddScoped<ISachRepository, SachRepository>();

            services.AddScoped<ITheLoaiRepository, TheLoaiRepository>();

            services.AddScoped<ISachTheLoaiRepository, SachTheLoaiRepository>();

            services.AddScoped<ITacGiaRepository, TacGiaRepository>();

            services.AddScoped<ISachTacGiaRepository, SachTacGiaRepository>();

            services.AddScoped<INxbRepository, NxbRepository>();
            services.AddScoped<INxbService, NxbService>();

            services.AddAutoMapper(typeof(AutoMapperConfig).Assembly);

            ServiceProvider = services.BuildServiceProvider();
        }

    }
}
