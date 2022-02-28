using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SE_BackEnd.Context;
using SE_BackEnd.Models;

namespace SE_BackEnd.Repositories
{
    public sealed class TransactionRepository : Repository<Transaction>,
        ITransactionRepository
    {
        public TransactionRepository(FamilyContext familyContext) : base(familyContext)
        {
        }

        public async Task<List<Transaction>> GetAllTransactionsForMember(Member member) =>
            await this.GetTable()
                .Include(x => x.Member)
                .Where(x => x.Member == member && x.CreatedAt > DateTime.Now.AddMonths(-1))
                .ToListAsync();
    }
}