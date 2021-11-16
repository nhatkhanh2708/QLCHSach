using AutoMapper;
using Model.Entities;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class Entity2DTOMappingProfile : Profile
    {
        public Entity2DTOMappingProfile()
        {
            //CreateMap<NhaXuatBan, NhaXuatBanDTO>()
              //  .ConstructUsing(c => new NhaXuatBanDTO())
        }
    }
}
