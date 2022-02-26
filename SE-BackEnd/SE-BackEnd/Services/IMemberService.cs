using SE_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SE_BackEnd.Services
{
    public interface IMemberService
    {
      Task<IEnumerable<Member>> GetAll();
      Task<Member> Get(Guid memberId);
      Task<Member> Update(Member member);
    }
}
