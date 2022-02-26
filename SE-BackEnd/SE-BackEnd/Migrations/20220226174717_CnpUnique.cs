using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SE_BackEnd.Migrations
{
    public partial class CnpUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_member_Cnp",
                table: "member",
                column: "Cnp",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_member_Cnp",
                table: "member");
        }
    }
}
