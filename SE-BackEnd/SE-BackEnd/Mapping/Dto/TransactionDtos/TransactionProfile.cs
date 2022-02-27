using System;
using AutoMapper;
using SE_BackEnd.Mapping.ForeignKeyResolvers;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.TransactionDtos
{
    public sealed class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            this.CreateMap<TransactionDto, Transaction>()
                .ForMember(m => m.Member,
                    opt =>
                    {
                        opt.MapFrom<MemberForeignKeyResolver, Guid?>(src => src.MemberId);
                        opt.SetMappingOrder(0);
                    })
                .ForMember(x => x.ModifiedAt, opt => opt.MapFrom(_ => DateTime.Now));
            this.CreateMap<Transaction, TransactionDto>()
                .ForMember(m => m.MemberId, opt => opt.MapFrom(x => x.Member.Id));
        }
    }
}