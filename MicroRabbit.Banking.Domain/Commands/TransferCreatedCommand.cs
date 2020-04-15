using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class TransferCreatedCommand : TransferCommand
    {
        public TransferCreatedCommand(int to,int from,decimal amount)
        {
            To = to;
            From = from;
            Amount = amount;
        }
    }
}
