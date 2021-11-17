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
        public IMapper Mapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperConfig());
            });
            return config.CreateMapper();
        }
    }
}
