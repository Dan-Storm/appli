using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appli.Migrations
{
    public partial class RecruiterUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Recruiter",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Recruiter");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec0cd8be-e139-47f8-aefc-e87be39eba0a", "AQAAAAEAACcQAAAAEDlK5hlS3JxMzALpFjvQmX03ujGUsrlJpTxhLTp1f5WGO+pCFep1okfM7+yoFvcnFA==" });

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastContact",
                value: new DateTime(2019, 9, 3, 14, 57, 12, 734, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastContact",
                value: new DateTime(2019, 9, 10, 14, 57, 12, 734, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastContact",
                value: new DateTime(2019, 9, 7, 14, 57, 12, 734, DateTimeKind.Local).AddTicks(6310));
        }
    }
}
