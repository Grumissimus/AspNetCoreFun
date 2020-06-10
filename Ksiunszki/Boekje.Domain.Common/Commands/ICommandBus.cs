using Boekje.Common.Results;

namespace Boekje.Common.Commands
{
    public interface ICommandBus
    {
        IResult Send<T>(T command) where T : ICommand;
    }
}