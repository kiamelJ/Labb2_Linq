using Microsoft.EntityFrameworkCore.Migrations;

namespace DBManyToManyTest1.Migrations
{
    public partial class UpdateTeacherCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teacher_Courses",
                columns: new[] { "TeacherId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 4 },
                    { 1, 3 },
                    { 3, 5 }
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
