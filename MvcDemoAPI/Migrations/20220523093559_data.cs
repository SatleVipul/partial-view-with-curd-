using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcDemoAPI.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl",
                table: "Tbl");

            migrationBuilder.RenameTable(
                name: "Tbl",
                newName: "emptbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emptbl",
                table: "emptbl",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_emptbl",
                table: "emptbl");

            migrationBuilder.RenameTable(
                name: "emptbl",
                newName: "Tbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl",
                table: "Tbl",
                column: "Id");
        }
    }
}
