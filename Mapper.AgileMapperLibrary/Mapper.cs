namespace Mapper.AgileMapperLibrary
{
    public class Mapper : Core.IMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return AgileObjects.AgileMapper.Mapper.Map(source).ToANew<TDestination>();
        }
    }
}
