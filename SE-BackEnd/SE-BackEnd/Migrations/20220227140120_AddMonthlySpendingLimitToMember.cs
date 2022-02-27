using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE_BackEnd.Migrations
{
    public partial class AddMonthlySpendingLimitToMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpendingLimit",
                table: "member",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpendingLimit",
                table: "member");
        }
    }
}
