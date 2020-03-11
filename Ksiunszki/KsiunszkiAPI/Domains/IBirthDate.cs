using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Domains
{
    internal interface IBirthDate
    {
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public string BirthPlace { get; set; }
        public void SetBirthDate(DateTime date);
    }
}
