using Boekje.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Models
{
    class Book : Entity
    {
        public ISBN ISBN { get; private set; }
        public string Title { get; private set; }
    }
}
