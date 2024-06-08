using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectifyHub.Infrastructure.Migrations
{
    public partial class UserNameUniqueConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ASPNETUSERS",
                keyColumn: "Id",
                keyValue: "12dcc3ab-8986-407c-8ad2-2b2096a13997");

            migrationBuilder.DeleteData(
                table: "ASPNETUSERS",
                keyColumn: "Id",
                keyValue: "2358f700-f99d-4e37-93d0-dd143024c518");

            migrationBuilder.DeleteData(
                table: "ASPNETUSERS",
                keyColumn: "Id",
                keyValue: "ba62dc97-bc35-4b79-97ed-2de84a833652");

            migrationBuilder.AddColumn<int>(
                name: "EntityStatus",
                table: "USERRELATIONSHIPS",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "ASPNETUSERS",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhotoUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "60d8e3df-9c1a-4b30-bf52-dbe246538ac3", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d2a70c5b-493f-4636-96d4-c51242d856d9", "yusuf@gmail.com", false, "Yusuf", "Ziya", false, null, "YUSUF@GMAIL.COM", "YZIYA", "AQAAAAEAACcQAAAAEPYY+TbQ6vV6jDSpGery7yBiXdeROwn9qU7XXq/e4mIv18QK/aKN9jKZVdXf5nQz7Q==", null, false, null, "442b1541-c73a-4f54-afc9-2de2695d7234", false, "yziya" },
                    { "72cd9cb9-d691-409b-85ec-515c13aa5e61", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "185c936a-a673-432e-967d-e9870a17f603", "husna@gmail.com", false, "Husna", "Kisla", false, null, "HUSNA@GMAIL.COM", "HKISLA", "AQAAAAEAACcQAAAAELmLRosmepQ/kWrcNqxe5USvF+jwjbGtoodM4TBUy/kt0QeE9IuYXiW3I/Rc6qCBjg==", null, false, null, "e5d3dbe5-6abc-4752-a6f2-c0d7898aa0d8", false, "hkisla" },
                    { "b3948e72-9070-4595-863c-dd9d0129a3f3", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "46ba43f6-605f-4991-bc8b-6dc9b30a8529", "erkut@gmail.com", false, "Erkut", "Ates", false, null, "ERKUT@GMAIL.COM", "EATES", "AQAAAAEAACcQAAAAELmLRosmepQ/kWrcNqxe5USvF+jwjbGtoodM4TBUy/kt0QeE9IuYXiW3I/Rc6qCBjg==", null, false, null, "b5ae825c-e409-4c9b-8834-dbfbaf8ea048", false, "eates" }
                });

            migrationBuilder.UpdateData(
                table: "POSTS",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 8, 23, 13, 51, 960, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CommentCreateTime", "CommentorID" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 13, 51, 960, DateTimeKind.Local).AddTicks(3053), "72cd9cb9-d691-409b-85ec-515c13aa5e61" });

            migrationBuilder.UpdateData(
                table: "LIKES",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "LikedTime", "LikerID" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 13, 51, 960, DateTimeKind.Local).AddTicks(3056), "b3948e72-9070-4595-863c-dd9d0129a3f3" });

            migrationBuilder.CreateIndex(
                name: "IX_ASPNETUSERS_UserName",
                table: "ASPNETUSERS",
                column: "UserName",
                unique: true,
                filter: "\"UserName\" IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ASPNETUSERS_UserName",
                table: "ASPNETUSERS");

            migrationBuilder.DeleteData(
                table: "ASPNETUSERS",
                keyColumn: "Id",
                keyValue: "60d8e3df-9c1a-4b30-bf52-dbe246538ac3");

            migrationBuilder.DeleteData(
                table: "ASPNETUSERS",
                keyColumn: "Id",
                keyValue: "72cd9cb9-d691-409b-85ec-515c13aa5e61");

            migrationBuilder.DeleteData(
                table: "ASPNETUSERS",
                keyColumn: "Id",
                keyValue: "b3948e72-9070-4595-863c-dd9d0129a3f3");

            migrationBuilder.DropColumn(
                name: "EntityStatus",
                table: "USERRELATIONSHIPS");

            migrationBuilder.InsertData(
                table: "ASPNETUSERS",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhotoUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12dcc3ab-8986-407c-8ad2-2b2096a13997", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "48b5cf12-ae5c-42cd-8dd1-57b70bf4164c", "yusuf@gmail.com", false, "Yusuf", "Ziya", false, null, "YUSUF@GMAIL.COM", "YZIYA", "AQAAAAEAACcQAAAAEDklFxmANJQDpKK4oD5SHXILBEsWuN37DR/Z3Fnrmkldws1Ly4XWZgeycgM9jQ+VnQ==", null, false, null, "703375a1-9a7c-4f1d-b551-72fcd49b93ed", false, "yziya" },
                    { "2358f700-f99d-4e37-93d0-dd143024c518", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6ce3b620-85fc-4d45-948a-812a67c1caf5", "husna@gmail.com", false, "Husna", "Kisla", false, null, "HUSNA@GMAIL.COM", "HKISLA", "AQAAAAEAACcQAAAAEAXN6I4p0Y2eVCbcjplqxa96E+bF/hGaOvHLWsc8ceXMQxo7DgfgLWDtgqjJuaaOmw==", null, false, null, "7fa459ec-9cff-424c-948d-7721df708965", false, "hkisla" },
                    { "ba62dc97-bc35-4b79-97ed-2de84a833652", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "47434536-c5e0-4d87-9ebf-4f3b66b732f6", "erkut@gmail.com", false, "Erkut", "Ates", false, null, "ERKUT@GMAIL.COM", "EATES", "AQAAAAEAACcQAAAAEAXN6I4p0Y2eVCbcjplqxa96E+bF/hGaOvHLWsc8ceXMQxo7DgfgLWDtgqjJuaaOmw==", null, false, null, "dc261a72-0396-4283-91a3-5ee54c31c27f", false, "eates" }
                });

            migrationBuilder.UpdateData(
                table: "POSTS",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 6, 22, 10, 12, 463, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "COMMENTS",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CommentCreateTime", "CommentorID" },
                values: new object[] { new DateTime(2024, 6, 6, 22, 10, 12, 463, DateTimeKind.Local).AddTicks(73), "2358f700-f99d-4e37-93d0-dd143024c518" });

            migrationBuilder.UpdateData(
                table: "LIKES",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "LikedTime", "LikerID" },
                values: new object[] { new DateTime(2024, 6, 6, 22, 10, 12, 463, DateTimeKind.Local).AddTicks(80), "ba62dc97-bc35-4b79-97ed-2de84a833652" });
        }
    }
}
