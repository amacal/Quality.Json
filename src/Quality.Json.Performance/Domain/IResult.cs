namespace Quality.Json.Performance.Domain
{
    public interface IResult
    {
        ICaseInfo Case { get; }

        IProcedure Procedure { get; }

        ISubjectInfo Subject { get; }

        IResultData Data { get; }
    }
}