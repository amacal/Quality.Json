using System;

namespace Quality.Json.Performance.Printers
{
    public class ConsolePrinter : PlainTextPrinter
    {
        public ConsolePrinter()
            : base(Console.Out, Console.WindowWidth - 1)
        {
        }
    }
}
