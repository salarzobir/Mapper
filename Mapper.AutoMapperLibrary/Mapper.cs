using AutoMapper;
using Mapper.DTO;
using Mapper.Entity;

namespace Mapper.AutoMapperLibrary
{
    public class Mapper : Core.IMapper
    {
        private readonly MapperConfiguration configuration;

        public Mapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDto>();
                cfg.CreateMap<Address, AddressDto>();
            });
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return configuration.CreateMapper().Map<TDestination>(source);
        }
    }
}
