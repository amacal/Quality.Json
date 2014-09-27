using Quality.Json.Performance.Cases;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Printers;
using Quality.Json.Performance.Procedures;
using Quality.Json.Performance.Subjects;
using System;
using System.IO;

namespace Quality.Json.Performance.Runner
{
    public class Program
    {
        public static void Main()
        {
            ITestSuitBuilder builder = new TestSuitBuilder();

            builder.AddCase(new MenuCase());
            builder.AddCase(new WidgetCase());
            builder.AddCase(new GlossaryCase());
            builder.AddCase(new RowCase());
            builder.AddCase(new WeatherCase());
            builder.AddCase(new CongressCase());
            builder.AddCase(new JobsCase());
            builder.AddCase(new NumberCase());
            builder.AddCase(new TwitterCase());

            builder.AddSubject(new NewtonsoftSubject());
            builder.AddSubject(new ServiceStackSubject());
            builder.AddSubject(new NetJsonSubject());
            builder.AddSubject(new NancySubject());
            builder.AddSubject(new JsonToolkitSubject());
            builder.AddSubject(new JilSubject());
            builder.AddSubject(new FastJsonSubject());

            builder.AddProcedure(new SerializeProcedure(100));
            builder.AddProcedure(new DeserializeProcedure(100));

            ITestSuit suit = builder.Build();
            IReport report = suit.Execute();

            TextWriter output = Console.Out;
            IReportPrinter printer = new PlanTextPrinter(Console.WindowWidth - 1);

            printer.Print(report, output);
            Console.ReadKey();
        }
    }
}
