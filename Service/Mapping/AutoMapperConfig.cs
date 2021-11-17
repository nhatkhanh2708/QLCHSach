using AutoMapper;

namespace Service.Mapping
{
    public class AutoMapperConfig
    {
        public IMapper RegisterMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DTO2EntityMapper());
                cfg.AddProfile(new Entity2DTOMapper());
            }).CreateMapper();
        }
    }
}
