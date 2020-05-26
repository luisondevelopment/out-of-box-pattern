using EventSourcing.Domain.Core.Events;
using System.ComponentModel;

namespace Consumer.Events
{
    [Description("ChangeLogEvent.Document.DataEmissao")] //Change to an specified attribute
    public class PolicyIssuanceEvent : ReceivedEvent
    {
        public string DocumentId { get; set; }
        public string DataEmissao { get; set; }

        public override string GetExchange()
        {
            throw new System.NotImplementedException();
        }
    }
}
