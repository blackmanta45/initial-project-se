using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SE_BackEnd.Models;

namespace SE_BackEnd.Repositories;

public interface IMemberRepository:IRepository<Member>
{
    Task<Member> Get(Guid memberId);
}