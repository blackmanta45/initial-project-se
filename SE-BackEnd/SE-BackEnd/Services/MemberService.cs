using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SE_BackEnd.Dto.MemberDtos;
using SE_BackEnd.Models;
using SE_BackEnd.Repositories;

namespace SE_BackEnd.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper mapper;

        public MemberService(IMemberRepository memberRepository, IMapper mapper)
        {
            this._memberRepository = memberRepository;
            this.mapper = mapper;
        }

        public async Task<Member> Get(Guid memberId) => await this._memberRepository.GetByIdAsync(memberId);

        public async Task<IEnumerable<Member>> GetAll() => await Task.FromResult(this._memberRepository.GetAll());

        public async Task<AddMemberResponseDto> Add(AddMemberRequestDto memberRequestDto)
        {
            var member = this.mapper.Map<Member>(memberRequestDto);
            member.CreatedAt = DateTime.Now;

            var memberResult = await this._memberRepository.AddAsync(member);

            if (memberResult == null)
                throw new Exception();

            return this.mapper.Map<AddMemberResponseDto>(memberResult);
        }

        public async Task<UpdateMemberResponseDto> Update(UpdateMemberRequestDto updateMemberRequestDto)
        {
            var member = this.mapper.Map<Member>(updateMemberRequestDto);
            var dbMember = await this._memberRepository.UpdateAsync(member);

            return this.mapper.Map<UpdateMemberResponseDto>(dbMember);
        }
    }
}