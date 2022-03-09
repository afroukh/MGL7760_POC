using Microsoft.EntityFrameworkCore.Migrations;

namespace MGL7760POC.Implementation.Repositories.Migrations
{
    public partial class addPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Declarations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NAS",
                table: "Declarations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Declarations");

            migrationBuilder.DropColumn(
                name: "NAS",
                table: "Declarations");
        }
    }
}
