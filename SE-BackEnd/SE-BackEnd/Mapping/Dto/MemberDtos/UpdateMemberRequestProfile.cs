using System;
using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.MemberDtos
{
    public sealed class UpdateMemberRequestProfile : Profile
    {
        public UpdateMemberRequestProfile()
        {
            this.CreateMap<UpdateMemberRequestDto, Member>()
                .ForMember(x => x.ModifiedAt, opt => opt.MapFrom(_ => DateTime.Now));
        }
    }
}