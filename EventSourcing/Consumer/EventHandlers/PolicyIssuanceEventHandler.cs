using System.Threading.Tasks;
using Consumer.Events;
using EventSourcing.Domain.Core.Bus;

namespace Consumer.EventHandlers
{
    public class PolicyIssuanceEventHandler : IEventHandlerReceived<PolicyIssuanceEvent>
    {
        public Task Handle(PolicyIssuanceEvent @event)
        {
            throw new System.NotImplementedException();
        }
    }
}
