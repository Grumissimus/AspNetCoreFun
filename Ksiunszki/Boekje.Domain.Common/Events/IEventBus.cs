using System.Threading.Tasks;

namespace Boekje.Common.Events
{
    public interface IEventBus
    {
        Task Publish<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}