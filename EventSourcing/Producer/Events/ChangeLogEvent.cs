using EventSourcing.Domain.Core.Events;
using System.Collections.Generic;

namespace Producer.Events
{
    public class ChangeLogEvent : Event
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string PrimaryKeyName { get; set; }
        public string PrimaryKeyValue { get; set; }
        public string ColumnName { get; set; }
        public string AlteredColumnValue { get; set; }
        private string Exchange { get { return $"{GetType().Name}.{TableName}.{ColumnName}";  } }

        public override string GetEventName()
        {
            return Exchange;
        }

        public override object GetContentToPublish()
        {
            return new Dictionary<string, dynamic>
            {
                { PrimaryKeyName, PrimaryKeyValue },
                { ColumnName, AlteredColumnValue },
                { "TableName", TableName },
                { "Date", Timestamp }
            };
        }
    }
}
