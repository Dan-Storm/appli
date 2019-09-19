using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appli.Migrations
{
    public partial class InterviewUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9937e54b-90fa-4b2c-84d8-c933eb3a2924", "AQAAAAEAACcQAAAAEECj2ycxUwlbAXzRY9JOI1eGGL0vDaIG8zeEtL5iNaT0j0p1GfnIRgeX3dhnrVuGVw==" });

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 29, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 6, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 9, 29, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastContact",
                value: new DateTime(2019, 9, 9, 10, 53, 47, 858, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastContact",
                value: new DateTime(2019, 9, 16, 10, 53, 47, 858, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastContact",
                value: new DateTime(2019, 9, 13, 10, 53, 47, 858, DateTimeKind.Local).AddTicks(7122));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1ec2f5a-ca62-4786-85ff-914b4d417327", "AQAAAAEAACcQAAAAEDLXpEgoL6Wm5vJkpwr35+S/UrVatHfpmyhwTLDJMr4ZeWTMHJGDd+++16SlCFHKfA==" });

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastContact",
                value: new DateTime(2019, 9, 6, 14, 27, 27, 217, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastContact",
                value: new DateTime(2019, 9, 13, 14, 27, 27, 218, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastContact",
                value: new DateTime(2019, 9, 10, 14, 27, 27, 218, DateTimeKind.Local).AddTicks(2144));
        }
    }
}
