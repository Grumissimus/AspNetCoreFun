using Boekje.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Models
{
    class AuthorName : ValueObject
    {
        private string _name;
        public string Name { get => _name; }

        public AuthorName(string name)
        {
            if ( string.IsNullOrEmpty(name) )
                throw new ArgumentNullException(nameof(name), "The author name cannot be null or empty");

            _name = name;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}
