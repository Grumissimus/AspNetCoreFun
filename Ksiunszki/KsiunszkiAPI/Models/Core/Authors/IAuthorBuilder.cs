using System;

namespace API.Models.Core.Authors
{
    public interface IAuthorBuilder
    {
        public IAuthorBuilder SetId(int id);
        public IAuthorBuilder SetName(string name);
        public IAuthorBuilder SetBirthDay(DateTime birthday);
        public IAuthorBuilder SetBirthPlace(string birthPlace);
        public IAuthorBuilder SetDeathDay(DateTime deathday);
        public IAuthorBuilder SetDeathPlace(string deathPlace);
        public IAuthorBuilder SetNationality(string nationality);
        public IAuthorBuilder SetGender(Gender gender);
        public IAuthorBuilder SetDescription(string description);
        public Author Build();
    }
}