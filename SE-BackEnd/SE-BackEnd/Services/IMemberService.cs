using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SE_BackEnd.Mapping.Dto.MemberDtos;
using SE_BackEnd.Models;

namespace SE_BackEnd.Services
{
    public interface IMemberService
    {
        Task<IEnumerable<Member>> GetAll();
        Task<Member> Get(Guid memberId);
        Task<AddMemberResponseDto> Add(AddMemberRequestDto memberRequestDto);
        Task<UpdateMemberResponseDto> Update(UpdateMemberRequestDto updateMemberRequestDto);
        Task Delete(Guid id);
    }
}