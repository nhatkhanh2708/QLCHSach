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
    public class DTO2EntityMappingProfile : Profile
    {
        public DTO2EntityMappingProfile()
        {
            //CreateMap<NhaXuatBanDTO, NhaXuatBan>()
              //  .ConstructUsing(c => new NhaXuatBan())
        }
    }
}
