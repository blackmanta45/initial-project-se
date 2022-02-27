using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Dto.MemberDtos;

public class DeleteMemberRequestProfile : Profile
{
    public DeleteMemberRequestProfile()
    {
        this.CreateMap<DeleteMemberRequestDto, Member>();
    }
}