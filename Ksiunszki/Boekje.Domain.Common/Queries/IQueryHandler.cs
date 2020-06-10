using Boekje.Common.Results;

namespace Boekje.Common.Queries
{
    public interface IQueryHandler
    {
    }

    public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery<TResult>
    {
        IResult<TResult> Execute(TQuery query);
    }
}