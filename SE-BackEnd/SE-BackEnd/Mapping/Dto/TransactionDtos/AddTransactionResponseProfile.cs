using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.TransactionDtos;

public sealed class AddTransactionResponseProfile : Profile
{
    public AddTransactionResponseProfile()
    {
        this.CreateMap<Transaction, AddTransactionResponseDto>();
    }
}