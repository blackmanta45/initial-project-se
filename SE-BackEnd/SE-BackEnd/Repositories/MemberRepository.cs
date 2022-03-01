using System.Collections.Generic;
using System.Linq;
using SE_BackEnd.Context;
using SE_BackEnd.Models;

namespace SE_BackEnd.Repositories;

public sealed class MemberRepository : Repository<Member>, IMemberRepository
{
    public MemberRepository(FamilyContext familyContext) : base(familyContext)
    {
    }

    public new IEnumerable<Member> GetAll() =>
        this.GetTable().Where(x => x.IsDeleted == false)
            .AsEnumerable();
}