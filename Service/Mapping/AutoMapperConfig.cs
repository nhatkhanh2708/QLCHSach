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
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<NhaXuatBan, NhaXuatBanDTO>();
            CreateMap<NhaXuatBanDTO, NhaXuatBan>();
        }
    }
}
