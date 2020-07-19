using Boekje.Common.Results;
using System.Threading.Tasks;

namespace Boekje.Common.Commands
{
    public interface ICommandBus
    {
        Task<IResult> Send<T>(T command) where T : ICommand;
    }
}