using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;
using System.Threading;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<TransferCreatedCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(TransferCreatedCommand request, CancellationToken cancellationToken)
        {
            //public event to RabbitMQ

            _bus.PublishCommand(new TransferCreatedEvent(
                request.From,
                request.To,
                request.Amount
                ));

            return Task.FromResult(true);
        }
    }
}
