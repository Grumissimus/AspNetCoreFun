using Boekje.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Models
{
    public class Publisher : Entity
    {
        public string Name { get; private set;}
        public string Description { get; private set; }
        public short FoundingYear { get; private set; }
        public string Website { get; private set; }
    }
}
