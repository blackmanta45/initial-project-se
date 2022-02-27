using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.MemberDtos
{
    public sealed class AddMemberResponseProfile : Profile
    {
        public AddMemberResponseProfile()
        {
            this.CreateMap<Member, AddMemberResponseDto>();
        }
    }
}