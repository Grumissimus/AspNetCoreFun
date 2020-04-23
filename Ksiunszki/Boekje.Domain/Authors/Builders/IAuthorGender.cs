using Boekje.Domain.Authors.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Authors.Builders
{
    public interface IAuthorGender
    {
        public Gender Gender { get; set; }
        IAuthorBuilder SetGender(Gender gender);
    }
}
