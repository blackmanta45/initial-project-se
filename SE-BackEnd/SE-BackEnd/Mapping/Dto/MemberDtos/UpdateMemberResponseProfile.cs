using AutoMapper;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.Dto.MemberDtos
{
    public sealed class UpdateMemberResponseProfile : Profile
    {
        public UpdateMemberResponseProfile()
        {
            this.CreateMap<Member, UpdateMemberResponseDto>();
        }
    }
}