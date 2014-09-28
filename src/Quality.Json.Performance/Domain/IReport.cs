namespace Quality.Json.Performance.Domain
{
    public interface IReport
    {
        void Print(IPrinter printer);
    }
}