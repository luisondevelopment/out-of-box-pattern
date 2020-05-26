namespace EventSourcing.Domain.Core.Events
{
    public abstract class ReceivedEvent
    {
        public abstract string GetExchange();
    }
}
