using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConnectifyHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ASPNETUSERS",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    FirstName = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "NVARCHAR2(255)", maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ProfilePhotoUrl = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "NVARCHAR2(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TIMESTAMP(7) WITH TIME ZONE", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASPNETUSERS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
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
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ClaimValue = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_ASPNETUSERS_UserId",
                        column: x => x.UserId,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_ASPNETUSERS_UserId",
                        column: x => x.UserId,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    RoleId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_ASPNETUSERS_UserId",
                        column: x => x.UserId,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    Value = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_ASPNETUSERS_UserId",
                        column: x => x.UserId,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MESSAGES",
                columns: table => new
                {
                    SenderID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ReceiverID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MessageContent = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SendTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ReadTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EntityStatus = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MESSAGES", x => new { x.SenderID, x.ReceiverID });
                    table.ForeignKey(
                        name: "FK_MESSAGES_ASPNETUSERS_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MESSAGES_ASPNETUSERS_SenderID",
                        column: x => x.SenderID,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "POSTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 2 INCREMENT BY 1"),
                    PostContent = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PostContentImageUrl = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    EntityStatus = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatorID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatorId = table.Column<string>(type: "NVARCHAR2(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_POSTS_ASPNETUSERS_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "USERRELATIONSHIPS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RequestTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ResponseTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    RelationshipStatus = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ActorID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    AffectedID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERRELATIONSHIPS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USERRELATIONSHIPS_ASPNETUSERS_ActorID",
                        column: x => x.ActorID,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USERRELATIONSHIPS_ASPNETUSERS_AffectedID",
                        column: x => x.AffectedID,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMMENTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 2 INCREMENT BY 1"),
                    CommentContent = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CommentCreateTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CommentEditTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    EntityStatus = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CommentorID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    PostID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMMENTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_COMMENTS_ASPNETUSERS_CommentorID",
                        column: x => x.CommentorID,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMMENTS_POSTS_PostID",
                        column: x => x.PostID,
                        principalTable: "POSTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LIKES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 2 INCREMENT BY 1"),
                    LikedTime = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EntityStatus = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LikeStatus = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LikerID = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    PostID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIKES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LIKES_ASPNETUSERS_LikerID",
                        column: x => x.LikerID,
                        principalTable: "ASPNETUSERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LIKES_POSTS_PostID",
                        column: x => x.PostID,
                        principalTable: "POSTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ASPNETUSERS",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhotoUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "361004f8-4195-49fe-886b-8d193654c9eb", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "012d1df1-f0bf-4fe4-8504-a0a4a487cfd6", "yusuf@gmail.com", 0, "Yusuf", "Ziya", 0, null, "YUSUF@GMAIL.COM", "YZIYA", "AQAAAAIAAYagAAAAEKrSxX1OtS+JsiSomDXHbRUWTQFHmHjomEg5kxUTSyHp5vtdqYJyz+GtJ4k4t2XZkQ==", null, 0, null, "18d11ae5-4be3-450c-8b99-d21c44f6dce8", 0, "yziya" },
                    { "70b26195-6d1d-40d6-bd23-a685287e740f", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "976dabbf-4eff-4caa-bdde-fbc55b0cc494", "husna@gmail.com", 0, "Husna", "Kisla", 0, null, "HUSNA@GMAIL.COM", "HKISLA", "AQAAAAIAAYagAAAAECyAm4NNaMkMHQ13VRZf5A7VNg/HlJCNdAFDqT4J6AyGNPjD96wwB8Ug6ndArRTogA==", null, 0, null, "d4010263-f5ab-48af-bc01-6b5c3c4b239c", 0, "hkisla" },
                    { "86b7b0a4-20af-488f-8dd9-4362256c9ae2", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b89fe9cc-4a65-4baf-bd0d-ad77433c6137", "erkut@gmail.com", 0, "Erkut", "Ates", 0, null, "ERKUT@GMAIL.COM", "EATES", "AQAAAAIAAYagAAAAECyAm4NNaMkMHQ13VRZf5A7VNg/HlJCNdAFDqT4J6AyGNPjD96wwB8Ug6ndArRTogA==", null, 0, null, "029c8f93-35e6-4ba8-b664-12655395096b", 0, "eates" }
                });

            migrationBuilder.InsertData(
                table: "POSTS",
                columns: new[] { "ID", "CreatedTime", "CreatorID", "CreatorId", "EditTime", "EntityStatus", "PostContent", "PostContentImageUrl" },
                values: new object[] { 1, new DateTime(2024, 6, 4, 22, 46, 31, 941, DateTimeKind.Local).AddTicks(9444), 1, null, null, 0, "Merhaba Dunya", "hello_world.png" });

            migrationBuilder.InsertData(
                table: "COMMENTS",
                columns: new[] { "ID", "CommentContent", "CommentCreateTime", "CommentEditTime", "CommentorID", "EntityStatus", "PostID" },
                values: new object[] { 1, "Ilk yorum", new DateTime(2024, 6, 4, 22, 46, 31, 941, DateTimeKind.Local).AddTicks(9473), null, "70b26195-6d1d-40d6-bd23-a685287e740f", 0, 1 });

            migrationBuilder.InsertData(
                table: "LIKES",
                columns: new[] { "ID", "EntityStatus", "LikeStatus", "LikedTime", "LikerID", "PostID" },
                values: new object[] { 1, 0, 0, new DateTime(2024, 6, 4, 22, 46, 31, 941, DateTimeKind.Local).AddTicks(9478), "86b7b0a4-20af-488f-8dd9-4362256c9ae2", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "\"NormalizedName\" IS NOT NULL");

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
                table: "ASPNETUSERS",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ASPNETUSERS",
                column: "NormalizedUserName",
                unique: true,
                filter: "\"NormalizedUserName\" IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_CommentorID",
                table: "COMMENTS",
                column: "CommentorID");

            migrationBuilder.CreateIndex(
                name: "IX_COMMENTS_PostID",
                table: "COMMENTS",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_LIKES_LikerID",
                table: "LIKES",
                column: "LikerID");

            migrationBuilder.CreateIndex(
                name: "IX_LIKES_PostID",
                table: "LIKES",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_MESSAGES_ReceiverID",
                table: "MESSAGES",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_POSTS_CreatorId",
                table: "POSTS",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_USERRELATIONSHIPS_ActorID",
                table: "USERRELATIONSHIPS",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_USERRELATIONSHIPS_AffectedID",
                table: "USERRELATIONSHIPS",
                column: "AffectedID");
        }

        /// <inheritdoc />
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
                name: "COMMENTS");

            migrationBuilder.DropTable(
                name: "LIKES");

            migrationBuilder.DropTable(
                name: "MESSAGES");

            migrationBuilder.DropTable(
                name: "USERRELATIONSHIPS");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "POSTS");

            migrationBuilder.DropTable(
                name: "ASPNETUSERS");
        }
    }
}
