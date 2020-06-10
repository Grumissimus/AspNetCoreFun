using System.Collections.Generic;
using Boekje.Common.Events;

namespace Boekje.Common.Entities
{
    /// <summary>
    /// A class for aggregates capable of event sourcing.
    /// </summary>
    // Based on: https://github.com/gregoryyoung/m-r/blob/master/SimpleCQRS/Domain.cs
    public abstract class EventSourcedAggregate : Entity
    {
        private readonly List<IEvent> _events;

        public IEnumerable<IEvent> GetUncommittedChanges()
        {
            return _events;
        }

        public void MarkChangesAsCommitted()
        {
            _events.Clear();
        }

        public void LoadsFromHistory(IEnumerable<IEvent> history)
        {
            foreach (var e in history)
                ApplyChange(e, false);
        }

        protected void ApplyChange(IEvent @event)
        {
            ApplyChange(@event, true);
        }

        private void ApplyChange(IEvent @event, bool isNew)
        {
            if (isNew) _events.Add(@event);
        }
    }
}