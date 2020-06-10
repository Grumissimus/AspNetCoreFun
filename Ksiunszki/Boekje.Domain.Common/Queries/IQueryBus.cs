using Boekje.Common.Results;

namespace Boekje.Common.Queries
{
    public interface IQueryBus
    {
        IResult<TResult> Send<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
    }
}