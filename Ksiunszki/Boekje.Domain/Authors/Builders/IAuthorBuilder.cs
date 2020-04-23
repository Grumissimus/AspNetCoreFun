using Boekje.Domain.Authors.Models;

namespace Boekje.Domain.Authors.Builders
{
    public interface IAuthorBuilder :
        IAuthorId,
        IAuthorName,
        IAuthorDate,
        IAuthorGender,
        IAuthorNationality,
        IAuthorDescription
    {
        Author Build();
        IAuthorBuilder Reset();
    }
}