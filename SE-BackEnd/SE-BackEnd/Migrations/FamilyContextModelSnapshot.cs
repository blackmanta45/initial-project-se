// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SE_BackEnd.Context;

#nullable disable

namespace SE_BackEnd.Migrations
{
    [DbContext(typeof(FamilyContext))]
    partial class FamilyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SE_BackEnd.Models.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Cnp")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SpendingLimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("member", (string)null);
                });

            modelBuilder.Entity("SE_BackEnd.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Details")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("transaction", (string)null);
                });

            modelBuilder.Entity("SE_BackEnd.Models.Transaction", b =>
                {
                    b.HasOne("SE_BackEnd.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
