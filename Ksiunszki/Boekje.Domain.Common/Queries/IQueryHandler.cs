using Boekje.Common.Results;
using System.Threading.Tasks;

namespace Boekje.Common.Queries
{
    public interface IQueryHandler
    {
    }

    public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery<TResult>
    {
        Task<IResult<TResult>> Execute(TQuery query);
    }
}