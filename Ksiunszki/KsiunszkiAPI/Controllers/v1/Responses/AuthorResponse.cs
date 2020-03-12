using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KsiunszkiAPI.Domains;

namespace KsiunszkiAPI.Controllers.v1.Responses
{
    public class AuthorResponse
    {
        public AuthorResponse(Author author)
        {
            Name = author.Name;
            Surname = author.Surname;
            Pseudonym = author.Pseudonym;
            BirthYear = author.BirthYear;
            BirthMonth = author.BirthMonth;
            BirthDay = author.BirthDay;
            BirthPlace = author.BirthPlace;

            DeathYear = author.DeathYear;
            DeathMonth = author.DeathMonth;
            DeathDay = author.DeathDay;
            DeathPlace = author.DeathPlace;
        }
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
    }
}
