using Mapper.DTO;
using Mapper.Entity;
using Nelibur.ObjectMapper;
using System.Collections.Generic;

namespace Mapper.TinyMapperLibrary
{
    public class Mapper : Core.IMapper
    {
        public Mapper()
        {
            TinyMapper.Bind<List<Customer>, List<CustomerDto>>();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return TinyMapper.Map<TDestination>(source);
        }
    }
}
