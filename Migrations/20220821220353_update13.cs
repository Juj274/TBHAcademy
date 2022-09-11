using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TBHAcademy.Migrations
{
    public partial class update13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignModules",
                columns: table => new
                {
                    AssignedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TutorID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModuleID = table.Column<int>(type: "int", nullable: false),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignModules", x => x.AssignedID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignModules");
        }
    }
}
