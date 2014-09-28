namespace Quality.Json.Performance.Domain
{
    public interface IInstance
    {
        ICaseInfo Case { get; }

        ISubjectInfo Subject { get; }

        IResult Execute(ITimes times);
    }
}