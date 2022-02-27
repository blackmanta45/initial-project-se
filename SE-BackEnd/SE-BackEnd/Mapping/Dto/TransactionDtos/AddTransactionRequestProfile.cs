using System;
using AutoMapper;
using SE_BackEnd.Mapping.ForeignKeyResolvers;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.TransactionDtos
{
    public sealed class AddTransactionRequestProfile : Profile
    {
        public AddTransactionRequestProfile()
        {
            this.CreateMap<AddTransactionRequestDto, Transaction>()
                .ForMember(x => x.Id, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(m => m.Member,
                    opt =>
                    {
                        opt.MapFrom<MemberForeignKeyResolver, Guid?>(src => src.MemberId);
                        opt.SetMappingOrder(0);
                    })
                .ForMember(x => x.CreatedAt, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(x => x.ModifiedAt, opt => opt.MapFrom(_ => DateTime.Now));
        }
    }
}