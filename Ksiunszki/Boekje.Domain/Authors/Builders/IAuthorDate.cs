using Boekje.Domain.Authors.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Builders
{
    public interface IAuthorDate
    {
        public DatePlace Birth { get; set; }
        public DatePlace Death { get; set; }
        IAuthorBuilder SetBirthday(DatePlace birthDatePlace);
        IAuthorBuilder SetDeathday(DatePlace deathDatePlace);
    }
}
