using System;

namespace API.Models.Core.Authors
{
    public interface IAuthorBuilder
    {
        IAuthorBuilder SetId(int id);
        IAuthorBuilder SetName(string name);
        IAuthorBuilder SetBirthDay(DateTime birthday);
        IAuthorBuilder SetBirthPlace(string birthPlace);
        IAuthorBuilder SetDeathDay(DateTime deathday);
        IAuthorBuilder SetDeathPlace(string deathPlace);
        IAuthorBuilder SetNationality(string nationality);
        IAuthorBuilder SetGender(Gender gender);
        IAuthorBuilder SetDescription(string description);
        Author Build();
    }
}