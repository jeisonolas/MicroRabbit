﻿using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public void Add(TransferLog transfer)
        {
            _context.Add(transfer);
            _context.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TransfersLogs;
        }

        
    }
}
