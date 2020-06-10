namespace Boekje.Common.Results
{
    public interface IResult
    {
        public bool IsValid();
    }

    public interface IResult<T> : IResult
    {
    }
}