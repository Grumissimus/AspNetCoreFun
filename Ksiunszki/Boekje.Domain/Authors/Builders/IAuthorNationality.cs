using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Builders
{
    public interface IAuthorNationality
    {
        public string Nationality { get; set; }
        IAuthorBuilder SetNationality(string nationality);
    }
}
