using Microsoft.EntityFrameworkCore.Migrations;

namespace DBManyToManyTest1.Migrations
{
    public partial class UpdateTeacherNameFromReidarToLena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Lena");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Reidar");
        }
    }
}
