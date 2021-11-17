using AutoMapper;
using Model.Entities;
using Service.DTOs;

namespace Service.Mapping
{
    public class DTO2EntityMapper : Profile
    {
        public DTO2EntityMapper()
        {
            CreateMap<NhaXuatBanDTO, NhaXuatBan>();
        }
    }
}
