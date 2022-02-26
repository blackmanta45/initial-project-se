using System;
using System.Threading.Tasks;
using SE_BackEnd.Models;

namespace SE_BackEnd.Repositories;

public interface IMemberRepository
{
    Task<Member> Get(Guid memberId);
    Task<Member> Put(Member member);
}