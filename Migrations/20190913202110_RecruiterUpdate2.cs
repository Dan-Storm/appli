using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appli.Migrations
{
    public partial class RecruiterUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "384fb64d-f902-49c4-a85b-d38ff0294621", "AQAAAAEAACcQAAAAEITRSomA5ZUJuMqA0stRUjuJk92zTs4+DbCOOHjvqSP/F8y/6enyslxMx9uFx1Dh4A==" });

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

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9c257f4-9d7b-49d5-adcc-fc4d83258242", "AQAAAAEAACcQAAAAEFgVpe02TuIbFzR8JpqEPbXK7LOTA1+IcSmifvhb6/qfG8Kr42/tu1C3xc0mMb5Tnw==" });

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastContact",
                value: new DateTime(2019, 9, 3, 15, 15, 47, 500, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastContact",
                value: new DateTime(2019, 9, 10, 15, 15, 47, 501, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastContact",
                value: new DateTime(2019, 9, 7, 15, 15, 47, 501, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "Recruiter",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: false);
        }
    }
}
