using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Builders
{
    public interface IAuthorName
    {
        public string Name { get; set; }
        public List<string> Aliases { get; set; }
        IAuthorBuilder SetName(string name);
        IAuthorBuilder SetAliases(List<string> Aliases);
    }
}
