using System;

namespace KsiunszkiAPI.Domains
{   internal interface IDeathDate
    { 
        public int DeathYear { get; set; }
        public int DeathMonth { get; set; }
        public int DeathDay { get; set; }
        public string DeathPlace { get; set; }
        public void SetDeathDate(DateTime date);
    }
}