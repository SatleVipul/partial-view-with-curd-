using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcDemoAPI.Migrations
{
    public partial class vip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tblEmployee",
                table: "tblEmployee");

            migrationBuilder.RenameTable(
                name: "tblEmployee",
                newName: "Tbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl",
                table: "Tbl",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl",
                table: "Tbl");

            migrationBuilder.RenameTable(
                name: "Tbl",
                newName: "tblEmployee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblEmployee",
                table: "tblEmployee",
                column: "Id");
        }
    }
}
