using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appli.Migrations
{
    public partial class RecruiterUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Recruiter",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "00000000-ffff-ffff-ffff-ffffffffffff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Recruiter");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "384fb64d-f902-49c4-a85b-d38ff0294621", "AQAAAAEAACcQAAAAEITRSomA5ZUJuMqA0stRUjuJk92zTs4+DbCOOHjvqSP/F8y/6enyslxMx9uFx1Dh4A==" });

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastContact",
                value: new DateTime(2019, 9, 3, 15, 21, 9, 446, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastContact",
                value: new DateTime(2019, 9, 10, 15, 21, 9, 447, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastContact",
                value: new DateTime(2019, 9, 7, 15, 21, 9, 447, DateTimeKind.Local).AddTicks(948));
        }
    }
}
