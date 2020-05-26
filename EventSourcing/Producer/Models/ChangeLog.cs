using EventSourcing.Domain.Core.Events;
using System;

namespace Producer.Models
{
    public class ChangeLog
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string PrimaryKeyName { get; set; }
        public string ColumnName { get; set; }
        public string AlteredColumnValue { get; set; }
        public bool Processed { get; set; }
        public DateTime? ProcessedAt { get; set; }
    }
}
