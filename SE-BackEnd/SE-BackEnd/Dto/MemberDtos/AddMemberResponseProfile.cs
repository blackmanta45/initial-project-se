using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Dto.MemberDtos;

public class AddMemberResponseProfile : Profile
{
    public AddMemberResponseProfile()
    {
        this.CreateMap<Member, AddMemberResponseDto>();
    }
}