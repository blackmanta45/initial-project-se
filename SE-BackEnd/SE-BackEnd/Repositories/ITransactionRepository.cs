using System.Collections.Generic;
using System.Threading.Tasks;
using SE_BackEnd.Models;

namespace SE_BackEnd.Repositories;

public interface ITransactionRepository : IRepository<Transaction>
{
    Task<List<Transaction>> GetAllTransactionsForMember(Member member);
}