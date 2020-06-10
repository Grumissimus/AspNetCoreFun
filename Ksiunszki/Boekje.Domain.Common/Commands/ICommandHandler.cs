using Boekje.Common.Results;

namespace Boekje.Common.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        IResult Execute(T command);
    }
}