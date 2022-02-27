using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SE_BackEnd.Entity;

namespace SE_BackEnd.Configurations
{
    internal abstract class EntityBaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : EntityBase
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.CreatedAt).IsRequired();
            builder.Property(e => e.ModifiedAt).IsRequired();
            builder.Property(e => e.IsDeleted).IsRequired();

            this.ConfigureCore(builder);
        }

        public abstract void ConfigureCore(EntityTypeBuilder<TEntity> builder);
    }
}