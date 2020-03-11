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
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public string BirthPlace { get; set; }
        public int DeathYear { get; set; }
        public int DeathMonth { get; set; }
        public int DeathDay { get; set; }
        public string DeathPlace { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
    }
}
