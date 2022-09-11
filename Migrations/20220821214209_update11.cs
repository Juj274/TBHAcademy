using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class update11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsssignedModules");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsssignedModules",
                columns: table => new
                {
                    AssignedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleID = table.Column<int>(type: "int", nullable: false),
                    TutorID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsssignedModules", x => x.AssignedID);
                });
        }
    }
}
