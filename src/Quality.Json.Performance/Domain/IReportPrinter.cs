using System.IO;

namespace Quality.Json.Performance.Domain
{
    public interface IReportPrinter
    {
        void Print(IReport report, TextWriter output);
    }
}