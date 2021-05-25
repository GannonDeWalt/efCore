using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class reformattedGradePdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradeP",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "GradeP",
                value: 90f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "GradeP",
                value: 25f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "GradeP",
                value: 75f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "GradeP",
                value: 85f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "GradeP",
                value: 75f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "GradeP",
                value: 55f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "GradeP",
                value: 0.2f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "GradeP",
                value: 0.9f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "GradeP",
                value: 0.25f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "GradeP",
                value: 0.75f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "GradeP",
                value: 0.85f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "GradeP",
                value: 0.75f);

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "GradeP",
                value: 0.55f);
        }
    }
}
