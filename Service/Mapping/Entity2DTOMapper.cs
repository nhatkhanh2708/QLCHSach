using AutoMapper;
using Model.Entities;
using Service.DTOs;

namespace Service.Mapping
{
    public class Entity2DTOMapper : Profile
    {
        public Entity2DTOMapper()
        {
            CreateMap<NhaXuatBan, NhaXuatBanDTO>();
        }
    }
}
