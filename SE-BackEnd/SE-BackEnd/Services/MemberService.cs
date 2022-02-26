using SE_BackEnd.Models;
using SE_BackEnd.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SE_BackEnd.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<Member> Get(Guid memberId)
        {
            return await _memberRepository.Get(memberId);
        }

        public async Task<IEnumerable<Member>> GetAll()
        {
            return await Task.FromResult(_memberRepository.GetAll());
        }

        public async Task<Member> Update(Member member)
        {
            return await _memberRepository.AddAsync(member);
        }
    }
}
