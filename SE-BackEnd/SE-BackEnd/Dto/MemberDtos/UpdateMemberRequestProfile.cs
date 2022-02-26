using System;
using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Dto.MemberDtos;

public class UpdateMemberRequestProfile : Profile
{
    public UpdateMemberRequestProfile()
    {
        this.CreateMap<UpdateMemberRequestDto, Member>()
            .ForMember(x => x.ModifiedAt, opt => opt.MapFrom(_ => DateTime.Now));
    }
}