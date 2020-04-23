using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Builders
{
    public interface IAuthorDescription
    {
        public string Description { get; set; }
        IAuthorBuilder SetDescription(string description);
    }
}
