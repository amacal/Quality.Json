using Quality.Json.Performance.Cases;
using Quality.Json.Performance.Domain;
using Quality.Json.Performance.Printers;
using Quality.Json.Performance.Procedures;
using Quality.Json.Performance.Subjects;
using Serilog;
using Serilog.Enrichers;
using Serilog.Events;
using System;
using System.IO;

namespace Quality.Json.Performance.Runner
{
    public class Program
    {
        public static void Main()
        {
            Program.InitializeLogger();
            Program.ExecuteTests();

            Console.ReadKey();
        }

        private static void InitializeLogger()
        {
            Log.Logger =
                new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .Enrich.WithThreadId()
                    .WriteTo.Console(LogEventLevel.Information)
                    .WriteTo.File("Quality.Json.Performance.Runner.txt", LogEventLevel.Debug)
                    .CreateLogger();
        }

        private static void ExecuteTests()
        {
            ITimes times = new Times(100);
            IParallelism parallelism = new Parallelism(Math.Max(Environment.ProcessorCount - 1, 1));

            ITestSuit suit = Program.CreateSuit();
            IReport report = suit.Execute(times, parallelism);

            report.Print(new ConsolePrinter());
        }

        private static ITestSuit CreateSuit()
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

            builder.AddProcedure(new SerializeProcedure());
            builder.AddProcedure(new DeserializeProcedure());

            return builder.Build();
        }
    }
}
