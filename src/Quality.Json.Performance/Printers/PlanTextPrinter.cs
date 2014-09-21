using Quality.Json.Performance.Domain;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quality.Json.Performance.Printers
{
    public class PlanTextPrinter : IReportPrinter
    {
        private readonly int width;

        public PlanTextPrinter(int width)
        {
            this.width = width;
        }

        public void Print(IReport report, TextWriter output)
        {
            int procedureWidth = 19;
            int nameWidth = this.width - 2 * procedureWidth;

            ICollection<IRemark> remarks = new List<IRemark>();

            foreach (IDescriptive @case in report.GetCases())
            {
                output.WriteLine("Case: {0}", @case.Name);
                output.WriteLine();
                output.WriteLine(new String('-', this.width));
                output.Write("Name".PadRight(nameWidth));
                output.Write("Serialization".PadLeft(procedureWidth));
                output.Write("Deserialization".PadLeft(procedureWidth));
                output.WriteLine();
                output.WriteLine(new String('-', this.width));

                foreach (IDescriptive subject in report.GetSubjects())
                {
                    IResultData serialization = report.GetSerializationData(subject, @case);
                    IResultData deserialization = report.GetDeserializationData(subject, @case);

                    output.Write(subject.Name.PadRight(nameWidth));
                    output.Write(serialization.ToString().PadLeft(procedureWidth));
                    output.Write(deserialization.ToString().PadLeft(procedureWidth));
                    output.WriteLine();

                    if (serialization.HasRemark())
                    {
                        remarks.Add(serialization.GetRemark());
                    }

                    if (deserialization.HasRemark())
                    {
                        remarks.Add(deserialization.GetRemark());
                    }
                }

                output.WriteLine(new String('-', this.width));
                output.WriteLine();
                output.WriteLine();
            }

            if (remarks.Count > 0)
            {
                output.WriteLine("Remarks:");
                output.WriteLine();

                foreach (IRemark remark in remarks)
                {
                    output.WriteLine("# {0}", remark);
                }
            }

            output.Flush();
        }
    }
}
