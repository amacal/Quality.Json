using Quality.Json.Performance.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            ICollection<IRemark> remarks = new List<IRemark>();

            foreach (ICaseInfo @case in report.GetCases())
            {
                this.PrintCaseHeader(output, @case);
                this.PrintCaseTable(output, report, @case, remarks);
            }

            this.PrintRemarks(output, remarks);
            output.Flush();
        }

        private void PrintCaseHeader(TextWriter output, ICaseInfo @case)
        {
            output.WriteLine("Case: {0}", @case.Name);
            output.WriteLine("Requirements: {0}", String.Join(", ", @case.GetRequirements().Select(x => x.Name).DefaultIfEmpty("none")));
            output.WriteLine();
        }

        private void PrintCaseTable(TextWriter output, IReport report, ICaseInfo @case, ICollection<IRemark> remarks)
        {
            this.PrintCaseTableHeader(output, @case);
            this.PrintCaseTableContent(output, report, @case, remarks);
            this.PrintCaseTableFooter(output);
        }

        private void PrintCaseTableHeader(TextWriter output, ICaseInfo @case)
        {
            int procedureWidth = 19;
            int nameWidth = this.width - 2 * procedureWidth;

            output.WriteLine(new String('-', this.width));
            output.Write("Name".PadRight(nameWidth));
            output.Write("Serialization".PadLeft(procedureWidth));
            output.Write("Deserialization".PadLeft(procedureWidth));
            output.WriteLine();
            output.WriteLine(new String('-', this.width));
        }

        private void PrintCaseTableContent(TextWriter output, IReport report, ICaseInfo @case, ICollection<IRemark> remarks)
        {
            int procedureWidth = 19;
            int nameWidth = this.width - 2 * procedureWidth;

            foreach (ISubjectInfo subject in report.GetSubjects())
            {
                IResultData serialization = report.GetSerializationData(subject, @case);
                IResultData deserialization = report.GetDeserializationData(subject, @case);

                output.Write(subject.Name.PadRight(nameWidth));
                output.Write(serialization.Describe().PadLeft(procedureWidth));
                output.Write(deserialization.Describe().PadLeft(procedureWidth));
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
        }

        private void PrintCaseTableFooter(TextWriter output)
        {
            output.WriteLine(new String('-', this.width));
            output.WriteLine();
            output.WriteLine();
        }

        private void PrintRemarks(TextWriter output, ICollection<IRemark> remarks)
        {
            if (remarks.Count > 0)
            {
                output.WriteLine("Remarks:");
                output.WriteLine();

                foreach (IRemark remark in remarks)
                {
                    output.WriteLine("# {0}", remark);
                }
            }
        }
    }
}