namespace Quality.Json.Performance.Domain
{
    public interface IResultData
    {
        bool HasRemark();

        IRemark GetRemark();

        string ToString();
    }
}