using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _service;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository service, IEventBus bus)
        {
            _service = service;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _service.GetAccounts();
        }

        public void Transfer(AccountTransfer transfer)
        {
            var createTransferCommand = new TransferCreatedCommand(
                transfer.FromAccount,
                transfer.ToAccount,
                transfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
