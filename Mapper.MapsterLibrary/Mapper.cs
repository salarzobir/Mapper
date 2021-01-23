using Mapster;

namespace Mapper.MapsterLibrary
{
    public class Mapper : Core.IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return source.Adapt<TDestination>();
        }
    }
}