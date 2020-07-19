using Boekje.Common.Results;
using System.Threading.Tasks;

namespace Boekje.Common.Queries
{
    public interface IQueryBus
    {
        Task<IResult<TResult>> Send<TQuery, TResult>(TQuery query) where TQuery : IQuery<TResult>;
    }
}