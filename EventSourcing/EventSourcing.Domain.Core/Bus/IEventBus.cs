using EventSourcing.Domain.Core.Commands;
using EventSourcing.Domain.Core.Events;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;

        void SubscribeReceive<T, TH>()
            where T : ReceivedEvent
            where TH : IEventHandlerReceived<T>;
    }
}
