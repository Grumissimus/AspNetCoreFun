using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boekje.Domain.Common.Events
{
    public interface IEventHandler<in TEvent> where TEvent : IEvent
    {
    }
}
