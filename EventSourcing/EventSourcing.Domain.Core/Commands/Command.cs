using EventSourcing.Domain.Core.Events;
using System;

namespace EventSourcing.Domain.Core.Commands
{
    public class Command : Message
    {
        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; protected set; }
    }
}
