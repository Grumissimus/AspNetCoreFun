using Boekje.Domain.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boekje.Domain.Authors.Models
{
    public enum Gender 
    {
        Unknown = 0b0,
        Male = 0b01,
        Female = 0b10,
        NonBinary = 0b11,
        Trans = 0b0100,
        TransMale = 0b101,
        TransFemale = 0b110
    }
}
