using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boekje.Domain.Common.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
    }
}
