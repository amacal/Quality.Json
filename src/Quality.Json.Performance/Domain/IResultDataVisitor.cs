using System;

namespace Quality.Json.Performance.Domain
{
    public interface IResultDataVisitor
    {
        void Visit(TimeSpan duration);
    }
}
