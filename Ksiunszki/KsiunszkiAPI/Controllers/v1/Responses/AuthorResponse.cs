using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Controllers.v1.Request
{
    public class AuthorResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pseudonym { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DeathDate { get; set; }
        public string DeathPlace { get; set; }
    }
}
