using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SE_BackEnd.Common;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.TransactionDtos
{
    public sealed class GetTransactionForMemberResponseProfile : Profile
    {
        public GetTransactionForMemberResponseProfile()
        {
            this.CreateMap<List<Transaction>, GetAllTransactionsForMemberResponseDto>()
                .ForMember(x => x.Transactions, opt => opt.MapFrom(source => source.Select(p => new TransactionDto
                {
                    MemberId = p.Member.Id,
                    Type = p.Type,
                    Price = p.Price,
                    Details = p.Details,
                    CreatedAt = p.CreatedAt
                })))
                .ForMember(x => x.TotalExpense, opt => opt.MapFrom(source => source.Any(x => x.Type == TransactionType.Expense) 
                    ? source.Where(x => x.Type == TransactionType.Expense).Sum(y => y.Price)
                : (decimal?) null))
                .ForMember(x => x.TotalIncome, opt => opt.MapFrom(source => source.Any(x => x.Type == TransactionType.Income) 
                    ? source.Where(x => x.Type == TransactionType.Income).Sum(y => y.Price)
                    : (decimal?) null))
                .ForMember(x => x.HighestExpense, opt => opt.MapFrom(source => source.Any(x => x.Type == TransactionType.Expense) 
                    ? source.Where(x => x.Type == TransactionType.Expense).Max(y => y.Price)
                    : (decimal?) null))
                .ForMember(x => x.LowestExpense, opt => opt.MapFrom(source => source.Any(x => x.Type == TransactionType.Expense) 
                    ? source.Where(x => x.Type == TransactionType.Expense).Min(y => y.Price)
                    : (decimal?) null))
                .ForMember(x => x.HighestIncome, opt => opt.MapFrom(source => source.Any(x => x.Type == TransactionType.Income) 
                    ? source.Where(x => x.Type == TransactionType.Income).Max(y => y.Price)
                    : (decimal?) null))
                .ForMember(x => x.LowestIncome, opt => opt.MapFrom(source => source.Any(x => x.Type == TransactionType.Income) 
                    ? source.Where(x => x.Type == TransactionType.Income).Min(y => y.Price)
                    : (decimal?) null))
                .AfterMap((src, dest) => dest.RemainingBudget = src.FirstOrDefault() is not null
                    ? dest.TotalExpense is not null ?
                        src.First().Member.SpendingLimit - dest.TotalExpense 
                        : src.First().Member.SpendingLimit
                    : null);
        }
    }
}