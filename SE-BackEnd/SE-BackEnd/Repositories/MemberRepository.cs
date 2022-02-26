using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SE_BackEnd.Context;
using SE_BackEnd.Models;

namespace SE_BackEnd.Repositories;

public sealed class MemberRepository : Repository<Member>, IMemberRepository
{
    public MemberRepository(FamilyContext familyContext) : base(familyContext)
    {
    }

    public async Task<Member> Get(Guid memberId)
    {
        return await GetQuery(e => e.Id == memberId).FirstOrDefaultAsync();
    }
}