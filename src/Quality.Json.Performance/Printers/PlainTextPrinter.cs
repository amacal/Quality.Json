using Quality.Json.Performance.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Quality.Json.Performance.Printers
{
    public class PlainTextPrinter : IPrinter
    {
        private readonly int width;
        private readonly TextWriter output;

        public PlainTextPrinter(TextWriter output, int width)
        {
            this.width = width;
            this.output = output;
        }

        public void Print(IReportInfo report)
        {
            ICollection<IRemark> remarks = new List<IRemark>();

            foreach (ICaseInfo @case in report.GetCases())
            {
                this.PrintCaseHeader(@case);
                this.PrintCaseTable(report, @case, remarks);
            }

            this.PrintRemarks(remarks);
            this.output.Flush();
        }

        private void PrintCaseHeader(ICaseInfo @case)
        {
            output.WriteLine("Case: {0}", @case.Name);
            output.WriteLine("Requirements: {0}", String.Join(", ", @case.GetRequirements().Select(x => x.Name).DefaultIfEmpty("none")));
            output.WriteLine();
        }

        private void PrintCaseTable(IReportInfo report, ICaseInfo @case, ICollection<IRemark> remarks)
        {
            this.PrintCaseTableHeader(@case);
            this.PrintCaseTableContent(report, @case, remarks);
            this.PrintCaseTableFooter();
        }

        private void PrintCaseTableHeader(ICaseInfo @case)
        {
            int procedureWidth = 19;
            int nameWidth = this.width - 2 * procedureWidth;

            this.output.WriteLine(new String('-', this.width));
            this.output.Write("Name".PadRight(nameWidth));
            this.output.Write("Serialization".PadLeft(procedureWidth));
            this.output.Write("Deserialization".PadLeft(procedureWidth));
            this.output.WriteLine();
            this.output.WriteLine(new String('-', this.width));
        }

        private void PrintCaseTableContent(IReportInfo report, ICaseInfo @case, ICollection<IRemark> remarks)
        {
            int procedureWidth = 19;
            int nameWidth = this.width - 2 * procedureWidth;

            foreach (ISubjectInfo subject in report.GetSubjects())
            {
                IResultData serialization = report.GetSerializationData(subject, @case);
                IResultData deserialization = report.GetDeserializationData(subject, @case);

                this.output.Write(subject.Name.PadRight(nameWidth));
                this.output.Write(serialization.Describe().PadLeft(procedureWidth));
                this.output.Write(deserialization.Describe().PadLeft(procedureWidth));
                this.output.WriteLine();

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

        private void PrintCaseTableFooter()
        {
            this.output.WriteLine(new String('-', this.width));
            this.output.WriteLine();
            this.output.WriteLine();
        }

        private void PrintRemarks(ICollection<IRemark> remarks)
        {
            if (remarks.Count > 0)
            {
                this.output.WriteLine("Remarks:");
                this.output.WriteLine();

                foreach (IRemark remark in remarks)
                {
                    this.output.WriteLine("# {0}", remark);
                }
            }
        }
    }
}