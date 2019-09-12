using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appli.Migrations
{
    public partial class updatejobAppmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NextInterview",
                table: "JobApplication");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4b1652b-e583-453d-8b0d-4ae16e505307", "AQAAAAEAACcQAAAAENbL4BIL0/0Um9O37+A3vIgpuxl5DxR7LbYkDGsCrk6NwHvL/hRkwb+H1RBnfLbPyw==" });

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 9, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastContact",
                value: new DateTime(2019, 9, 1, 17, 27, 56, 374, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastContact",
                value: new DateTime(2019, 9, 8, 17, 27, 56, 374, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastContact",
                value: new DateTime(2019, 9, 5, 17, 27, 56, 374, DateTimeKind.Local).AddTicks(6791));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NextInterview",
                table: "JobApplication",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57f05e17-933a-4237-9c42-91b7832e4a6a", "AQAAAAEAACcQAAAAEBdyf+ln2Xab+8tPIwwWhhVE6KfMAdBNgpJBEyHFR6AF0LXPaCOUe53WNIW7a0EYGg==" });

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Interview",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastContact",
                value: new DateTime(2019, 8, 30, 9, 21, 5, 833, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastContact",
                value: new DateTime(2019, 9, 6, 9, 21, 5, 833, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "JobApplication",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastContact",
                value: new DateTime(2019, 9, 3, 9, 21, 5, 833, DateTimeKind.Local).AddTicks(6616));
        }
    }
}
