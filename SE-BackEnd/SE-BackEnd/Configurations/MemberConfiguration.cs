using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE_BackEnd.Models;

namespace SE_BackEnd.Configurations
{
    internal class MemberConfiguration : EntityBaseEntityConfiguration<Member>
    {
        public override void ConfigureCore(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("member");

            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.Cnp).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.SpendingLimit).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
        }
    }
}
