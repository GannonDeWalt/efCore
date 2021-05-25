using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class sophomores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "classification" },
                values: new object[] { 6, 14, "Harambe", "Gorilla", 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "classification" },
                values: new object[] { 7, 14, "Doug", "Dimmadome", 1 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GradeP", "StudentId" },
                values: new object[] { 100f, 6 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "GradeP", "StudentId" },
                values: new object[] { 8, "Geometry", 55f, 6 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "GradeP", "StudentId" },
                values: new object[] { 9, "Venting", 40f, 7 });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseName", "GradeP", "StudentId" },
                values: new object[] { 10, "Mathematics", 75f, 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GradeP", "StudentId" },
                values: new object[] { 55f, 2 });
        }
    }
}
