using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Dto.MemberDtos;

public class UpdateMemberResponseProfile : Profile
{
    public UpdateMemberResponseProfile()
    {
        this.CreateMap<UpdateMemberResponseDto, Member>();
    }
}