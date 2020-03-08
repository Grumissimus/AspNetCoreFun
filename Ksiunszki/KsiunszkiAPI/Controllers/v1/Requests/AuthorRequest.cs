using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Controllers.v1.Requests
{
    public class AuthorRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pseudonym { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DeathDate { get; set; }
        public string DeathPlace { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
    }
}
