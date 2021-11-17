using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    public class NhanVienConfig : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.OwnsOne(s => s.DiaChi);
            builder.Property(s => s.SDT)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
