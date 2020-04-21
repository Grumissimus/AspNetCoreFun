using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Common.Aggregates
{
    public interface IAggregateRoot<TId>
    {
        TId Id { get; set; }
    }
}
