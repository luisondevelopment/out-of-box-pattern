using EventSourcing.Domain.Core.Events;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandlerReceived<in TEvent> : IEventHandler
    where TEvent : ReceivedEvent
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
