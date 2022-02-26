using AutoMapper;
using SE_BackEnd.Models;
using System;

namespace SE_BackEnd.Dto.MemberDtos
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            this.CreateMap<AddMemberDto, Member>()
                .ForMember(x => x.Id, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(x => x.ModifiedAt, opt => opt.MapFrom(_ => DateTime.Now));
            this.CreateMap<Member, AddMemberDto>();
                
        }
    }
}
