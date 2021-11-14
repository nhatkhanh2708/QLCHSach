using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Entities.Sach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    public class SachTheLoaiConfig : IEntityTypeConfiguration<SachTheLoai>
    {
        public void Configure(EntityTypeBuilder<SachTheLoai> builder)
        {
            
        }
    }
}
