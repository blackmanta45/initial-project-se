using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE_BackEnd.Models;

namespace SE_BackEnd.Configurations
{
    internal class TransactionConfiguration : EntityBaseEntityConfiguration<Transaction>
    {
        public override void ConfigureCore(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("transaction");

            builder.Property(p => p.Type).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Details);
            builder.Property(p => p.IsDeleted);

            builder.HasOne(p => p.Member);
        }
    }
}
