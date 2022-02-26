using SE_BackEnd.Context;
using SE_BackEnd.Models;

namespace SE_BackEnd.Repositories;

public sealed class MemberRepository : Repository<Member>, IMemberRepository
{
    public MemberRepository(FamilyContext familyContext) : base(familyContext)
    {
    }
}