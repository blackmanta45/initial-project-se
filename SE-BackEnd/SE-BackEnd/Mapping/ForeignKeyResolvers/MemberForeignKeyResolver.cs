using Microsoft.EntityFrameworkCore;
using SE_BackEnd.Context;
using SE_BackEnd.Models;

namespace SE_BackEnd.Mapping.ForeignKeyResolvers
{
    public class MemberForeignKeyResolver  : EntityForeignKeyResolver<Member>
    {
        public MemberForeignKeyResolver(FamilyContext db) : base(db)
        {
        }

        protected override DbSet<Member> DbSet => this.Db.Members;
    }
}