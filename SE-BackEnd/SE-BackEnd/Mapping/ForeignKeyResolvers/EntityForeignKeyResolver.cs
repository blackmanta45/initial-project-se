using System;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SE_BackEnd.Context;
using SE_BackEnd.Entity;

namespace SE_BackEnd.Mapping.ForeignKeyResolvers
{
    public abstract class EntityForeignKeyResolver<TDest> : IMemberValueResolver<object, object, Guid?, TDest>
        where TDest : EntityBase
    {
        protected EntityForeignKeyResolver(FamilyContext db)
        {
            this.Db = db;
        }

        protected FamilyContext Db { get; }

        protected abstract DbSet<TDest> DbSet { get; }

        public TDest Resolve(
            object source,
            object destination,
            Guid? sourceMember,
            TDest destMember,
            ResolutionContext context) =>
            sourceMember == null ? null : this.DbSet.First(x => x.Id == sourceMember);
    }
}