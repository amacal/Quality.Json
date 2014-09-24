namespace Quality.Json.Performance.Domain
{
    public interface ISubjectInfo : IDescriptive
    {
        bool CanHandle(IRequirement requirement);
    }
}