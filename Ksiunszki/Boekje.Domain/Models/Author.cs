using Boekje.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Models
{
    public class Author : Entity
    {
        public string Name { get; private set; }

        public Author()
        {
        }
    }
}
