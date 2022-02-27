using Microsoft.EntityFrameworkCore;
using SE_BackEnd.Configurations;
using SE_BackEnd.Models;

namespace SE_BackEnd.Context
{
    public class FamilyContext : DbContext
    {
        public FamilyContext(DbContextOptions<FamilyContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MemberConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
        }
    }
}