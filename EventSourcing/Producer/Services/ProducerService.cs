using EventSourcing.Domain.Core.Bus;
using Producer.Events;
using Producer.Repository;
using System.Linq;

namespace Producer.Services
{
    public class ProducerService
    {
        private readonly ChangeLogContext _ctx;
        private readonly IEventBus _bus;

        public ProducerService(ChangeLogContext ctx, IEventBus bus)
        {
            _ctx = ctx;
            _bus = bus;
        }

        public void Produce()
        {
            var toProcess = _ctx.ChangeLog.Where(x => !x.Processed).ToList();

            toProcess.ForEach(x => _bus.Publish(new ChangeLogEvent() 
            { 
                TableName = x.TableName,
                ColumnName = x.ColumnName,
                PrimaryKeyName = x.PrimaryKeyName,
                AlteredColumnValue = x.AlteredColumnValue,
            }));
        }
    }
}
