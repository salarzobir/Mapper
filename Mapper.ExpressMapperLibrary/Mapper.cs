namespace Mapper.ExpressMapperLibrary
{
    public class Mapper : Core.IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return ExpressMapper.Mapper.Map<TSource, TDestination>(source);
        }
    }
}
