using Boekje.Common.Results;
using System.Threading.Tasks;

namespace Boekje.Common.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task<IResult> Execute(T command);
    }
}