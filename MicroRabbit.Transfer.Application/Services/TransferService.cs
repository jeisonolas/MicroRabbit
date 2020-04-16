using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transfer;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transfer,IEventBus bus)
        {
            _transfer = transfer;
            _bus = bus;
        }

        public void Add(TransferLog transfer)
        {
            _transfer.Add(transfer);
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transfer.GetTransferLogs();
        }
    }
}
