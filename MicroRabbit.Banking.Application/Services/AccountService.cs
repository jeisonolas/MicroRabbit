using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _service;

        public AccountService(IAccountRepository service)
        {
            _service = service;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _service.GetAccounts();
        }
    }
}
