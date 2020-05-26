using System;

namespace EventSourcing.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }

        public abstract string GetEventName();
        public abstract object GetContentToPublish();
    }
}
