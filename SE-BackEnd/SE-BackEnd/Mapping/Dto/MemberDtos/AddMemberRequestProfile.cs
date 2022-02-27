using System;
using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.MemberDtos
{
    public sealed class AddMemberRequestProfile : Profile
    {
        public AddMemberRequestProfile()
        {
            this.CreateMap<AddMemberRequestDto, Member>()
                .ForMember(x => x.Id, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(x => x.CreatedAt, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(x => x.ModifiedAt, opt => opt.MapFrom(_ => DateTime.Now));
        }
    }
}