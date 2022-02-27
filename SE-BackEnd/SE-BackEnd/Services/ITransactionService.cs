using System;
using System.Threading.Tasks;
using SE_BackEnd.Mapping.Dto.TransactionDtos;

namespace SE_BackEnd.Services;

public interface ITransactionService
{
    Task<AddTransactionResponseDto> Add(AddTransactionRequestDto dto);
    Task<GetAllTransactionsForMemberResponseDto> GetAllTransactionsForMember(Guid memberId);
    Task<TransactionDto> Get(Guid transactionId);
}