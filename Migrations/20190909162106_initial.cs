using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appli.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recruiter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 40, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruiter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobApplication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    NextInterview = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    CompanyName = table.Column<string>(maxLength: 30, nullable: false),
                    Position = table.Column<string>(maxLength: 30, nullable: false),
                    RecruiterId = table.Column<int>(nullable: true),
                    PositionLink = table.Column<string>(nullable: true),
                    Rejected = table.Column<bool>(nullable: false),
                    Offer = table.Column<string>(nullable: true),
                    LastContact = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Notes = table.Column<string>(maxLength: 300, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplication_Recruiter_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "Recruiter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobApplication_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interview",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobApplicationId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Address = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interview_JobApplication_JobApplicationId",
                        column: x => x.JobApplicationId,
                        principalTable: "JobApplication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "57f05e17-933a-4237-9c42-91b7832e4a6a", "ApplicationUser", "deep@patel.com", true, false, null, "DEEP@PATEL.COM", "DEEP@PATEL.COM", "AQAAAAEAACcQAAAAEBdyf+ln2Xab+8tPIwwWhhVE6KfMAdBNgpJBEyHFR6AF0LXPaCOUe53WNIW7a0EYGg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "deep@patel.com", "Deep", "Patel" });

            migrationBuilder.InsertData(
                table: "Recruiter",
                columns: new[] { "Id", "EmailAddress", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "janki@deep.com", "Janki Patel", "615-224-2345" },
                    { 2, "anuj@deep.com", "Anuj Patel", "615-334-4565" },
                    { 3, "Shreeda@deep.com", "Shreeda Patel", "847-123-4565" }
                });

            migrationBuilder.InsertData(
                table: "JobApplication",
                columns: new[] { "Id", "CompanyName", "IsActive", "LastContact", "Notes", "Offer", "Position", "PositionLink", "RecruiterId", "Rejected", "UserId" },
                values: new object[] { 1, "Google", true, new DateTime(2019, 8, 30, 9, 21, 5, 833, DateTimeKind.Local).AddTicks(3826), "I'm still on the fence about this company, I was hoping for more health coverage than dental", "$1,000,000 and dental", "Full Stack Dev", "www.google.com", null, false, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "JobApplication",
                columns: new[] { "Id", "CompanyName", "IsActive", "LastContact", "Notes", "Offer", "Position", "PositionLink", "RecruiterId", "Rejected", "UserId" },
                values: new object[] { 2, "Apple", true, new DateTime(2019, 9, 6, 9, 21, 5, 833, DateTimeKind.Local).AddTicks(6587), "Really like this company, I'm just more of an orange guy", "$1,000,001 and vision", "Front End Dev", "www.apple.com", null, false, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "JobApplication",
                columns: new[] { "Id", "CompanyName", "IsActive", "LastContact", "Notes", "Offer", "Position", "PositionLink", "RecruiterId", "Rejected", "UserId" },
                values: new object[] { 3, "Facebook", true, new DateTime(2019, 9, 3, 9, 21, 5, 833, DateTimeKind.Local).AddTicks(6616), "Really dont like this company, pretty sure the CEO is a lizard person", "$1,000,002 and health", "React End Dev", "www.facebook.com", null, false, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Interview",
                columns: new[] { "Id", "Address", "Date", "JobApplicationId", "Notes" },
                values: new object[,]
                {
                    { 1, "510 Old Hickory Blvd", new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, "Wear a nice shirt" },
                    { 2, "50 Hickory Blvd", new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 1, "Wear a really nice shirt" },
                    { 3, "5100 Old Blvd", new DateTime(2019, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), 2, "Wear a nice shirt like Deep would" },
                    { 4, "100 Old Town Road", new DateTime(2019, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 2, "Smile" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_JobApplicationId",
                table: "Interview",
                column: "JobApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_RecruiterId",
                table: "JobApplication",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplication_UserId",
                table: "JobApplication",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Interview");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "JobApplication");

            migrationBuilder.DropTable(
                name: "Recruiter");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
