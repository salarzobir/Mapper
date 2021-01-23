namespace Mapper.Core
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
    }
}
