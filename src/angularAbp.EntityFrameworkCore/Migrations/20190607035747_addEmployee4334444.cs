using Microsoft.EntityFrameworkCore.Migrations;

namespace angularAbp.Migrations
{
    public partial class addEmployee4334444 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ME");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employee",
                newSchema: "ME");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Employee",
                schema: "ME",
                newName: "Employee");
        }
    }
}
