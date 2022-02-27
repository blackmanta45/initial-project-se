using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE_BackEnd.Migrations
{
    public partial class AddedMemberConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "transaction",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "member",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "transaction");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "member");
        }
    }
}
