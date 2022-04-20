using Microsoft.EntityFrameworkCore.Migrations;

namespace DBManyToManyTest1.Migrations
{
    public partial class InitSeedAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "1A" },
                    { 2, "1B" },
                    { 3, "2A" },
                    { 4, "2B" },
                    { 5, "3A" },
                    { 6, "3B" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Programmering 1" },
                    { 2, "Programmering 2" },
                    { 3, "Programmering 3" },
                    { 4, "OOP" },
                    { 5, "Databasteknik" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Anas" },
                    { 2, "Reidar" },
                    { 3, "Reidar" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Alice" },
                    { 15, 6, "Selma" },
                    { 14, 5, "Oliver" },
                    { 12, 4, "Oscar" },
                    { 11, 4, "Freja" },
                    { 10, 4, "Liam" },
                    { 9, 3, "Wilma" },
                    { 13, 5, "Olivia" },
                    { 7, 3, "Astrid" },
                    { 6, 2, "Hugo" },
                    { 5, 2, "Elsa" },
                    { 4, 2, "William" },
                    { 3, 1, "Maja" },
                    { 2, 1, "Noah" },
                    { 8, 3, "Lucas" }
                });

            migrationBuilder.InsertData(
                table: "Teacher_Classes",
                columns: new[] { "TeacherId", "ClassId" },
                values: new object[,]
                {
                    { 3, 6 },
                    { 3, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 1, 2 },
                    { 1, 1 }
                });

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

            migrationBuilder.InsertData(
                table: "Course_Students",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 14 },
                    { 5, 13 },
                    { 4, 12 },
                    { 4, 11 },
                    { 4, 10 },
                    { 3, 9 },
                    { 5, 15 },
                    { 3, 7 },
                    { 2, 6 },
                    { 3, 8 },
                    { 1, 3 },
                    { 2, 5 },
                    { 2, 4 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Teacher_Students",
                columns: new[] { "TeacherId", "StudentId" },
                values: new object[,]
                {
                    { 3, 14 },
                    { 1, 1 },
                    { 3, 13 },
                    { 3, 12 },
                    { 1, 2 },
                    { 3, 11 },
                    { 2, 6 },
                    { 3, 10 },
                    { 1, 3 },
                    { 1, 9 },
                    { 1, 8 },
                    { 2, 4 },
                    { 1, 7 },
                    { 2, 5 },
                    { 3, 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "Course_Students",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "Teacher_Classes",
                keyColumns: new[] { "TeacherId", "ClassId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Teacher_Classes",
                keyColumns: new[] { "TeacherId", "ClassId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Teacher_Classes",
                keyColumns: new[] { "TeacherId", "ClassId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Teacher_Classes",
                keyColumns: new[] { "TeacherId", "ClassId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Teacher_Classes",
                keyColumns: new[] { "TeacherId", "ClassId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Teacher_Classes",
                keyColumns: new[] { "TeacherId", "ClassId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Teacher_Courses",
                keyColumns: new[] { "TeacherId", "CourseId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Teacher_Courses",
                keyColumns: new[] { "TeacherId", "CourseId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Teacher_Courses",
                keyColumns: new[] { "TeacherId", "CourseId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Teacher_Courses",
                keyColumns: new[] { "TeacherId", "CourseId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Teacher_Courses",
                keyColumns: new[] { "TeacherId", "CourseId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "Teacher_Students",
                keyColumns: new[] { "TeacherId", "StudentId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
