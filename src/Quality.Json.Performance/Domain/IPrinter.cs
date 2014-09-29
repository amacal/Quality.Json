using System.IO;

namespace Quality.Json.Performance.Domain
{
    public interface IPrinter
    {
        void Print(IReportInfo report);
    }
}