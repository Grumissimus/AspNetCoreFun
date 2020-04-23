using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Builders
{
    public interface IAuthorId
    {
        public long Id { get; set; }
        IAuthorBuilder SetId(int name);
    }
}
