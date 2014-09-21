﻿using Quality.Json.Performance.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quality.Json.Performance.Domain
{
    internal class Report : IReport
    {
        private readonly List<IResult> items;

        public Report()
        {
            this.items = new List<IResult>();
        }

        public void AddResult(IResult item)
        {
            this.items.Add(item);
        }

        public IEnumerable<IDescriptive> GetCases()
        {
            return this.items.Select(x => x.Case).Distinct().OrderBy(x => x.Name);
        }

        public IEnumerable<IDescriptive> GetSubjects()
        {
            return this.items.Select(x => x.Subject).Distinct().OrderBy(x => x.Name);
        }

        public IResultData GetDeserializationData(IDescriptive subject, IDescriptive @case)
        {
            return this.items
                .Where(x => x.Subject== subject)
                .Where(x => x.Case == @case)
                .Where(x => x.Procedure.Name == "Deserialize")
                .Select(x => x.Data)
                .DefaultIfEmpty(new NotSupportedRequirementResult())
                .FirstOrDefault();
        }

        public IResultData GetSerializationData(IDescriptive subject, IDescriptive @case)
        {
            return this.items
                .Where(x => x.Subject == subject)
                .Where(x => x.Case == @case)
                .Where(x => x.Procedure.Name == "Serialize")
                .Select(x => x.Data)
                .DefaultIfEmpty(new NotSupportedRequirementResult())
                .FirstOrDefault();
        }
    }
}
