using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTXServer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductIntro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInProductType", x => new { x.ProductTypeId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInProductType_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInProductType_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductCover", "ProductDescription", "ProductIntro", "ProductName", "ProductRate" },
                values: new object[,]
                {
                    { "014479ad-ed74-4eda-8050-5e747072c9ae", "css/images/movie15.jpg", "This is YourName Product", "link clip", "YourName", 5 },
                    { "1169072a-954e-4e9c-a266-b55b62993194", "css/images/vothanchuate.PNG", "This is naruto1 Product", "link clip", "Naruto1", 5 },
                    { "124d8f9b-dffe-4da2-9664-bb0a7d83f81d", "css/images/movie3.jpg", "This is Thế Giới Hoàn Mỹ Product", "link clip", "Thế Giới Hoàn Mỹ", 5 },
                    { "14c978ce-f118-45f1-afd3-2459375ba6ab", "css/images/movie7.jpg", "This is Võ Thần Chúa Tể Product", "link clip", "Võ Thần Chúa Tể", 5 },
                    { "16156fcc-ed78-40c3-b83b-589f14e26ede", "css/images/movie13.jpg", "This is Naruto2 Product", "link clip", "Naruto2", 5 },
                    { "1617bbdc-efe3-4c79-8a70-28ff4b434346", "css/images/dauladailuc.PNG", "This is Mavel Product", "link clip", "Mavel", 1 },
                    { "2891735f-2709-4607-bd72-0cb9c5f3a7e7", "css/images/movie12.jpg", "This is Songoku2 Product", "link clip", "Songoku2", 5 },
                    { "6101c876-00a5-4d1f-9c1f-71673f5e1874", "css/images/movie10.jpg", "This is Đấu La Đại Lục Product", "link clip", "Đấu La Đại Lục", 5 },
                    { "66f3ce30-ae63-40d6-b156-c8c077016552", "css/images/dauphathuongkhung.PNG", "This is Songoku1 Product", "link clip", "Sogoku1", 5 },
                    { "67874a01-69cc-490a-81bc-c53678e332f3", "css/images/movie4.jpg", "This is Nghịch Thiên Chí Tôn Product", "link clip", "Nghịch Thiên Chí Tôn", 5 },
                    { "6b0e5969-fdf9-4a05-8ae9-4e189144dadb", "css/images/movie5.jpg", "This is Tru Tiên Product", "link clip", "Tru Tiên", 5 },
                    { "775bc0bb-178d-40d1-8d80-509871237ab4", "css/images/yeuthanky.PNG", "This is Connan Product", "link clip", "Connan", 3 },
                    { "97cea438-1e6e-45f2-8ecd-158e9f951f5c", "css/images/vangioitienlung.PNG", "This is Spider Man Product", "link clip", "Spider Man", 1 },
                    { "a9bd868f-199b-49bf-8af8-7ac43a91cd32", "css/images/movie8.jpg", "This is Vạn Giới Thần Chủ Product", "link clip", "Vạn Giới Thần Chủ", 5 },
                    { "b93bbc67-d8eb-4663-bd42-e684e68a616a", "css/images/movie14.jpg", "This is Kamen Rider Product", "link clip", "Kamen Rider", 5 },
                    { "d492848b-c23c-4ab8-9195-2cd07970157d", "css/images/Thegioihoanmy.PNG", "This is Tom And Jerry Product", "link clip", "Tom And Jerry", 3 },
                    { "dc6b035f-2395-4ef0-aa1a-41a79351bf92", "css/images/movie2.jpg", "This is Đấu Phá Thương Khung Product", "link clip", "Đấu Phá Thương Khung", 5 },
                    { "e5e2300e-4ee6-4a3c-b9e8-b8cb9b7dc539", "css/images/movie6.jpg", "This is Vạn Giới Tiên Lung Product", "link clip", "Vạn Giới Tiên Lung", 5 },
                    { "e9583c8a-bd6f-4a70-8264-a117b42029f0", "css/images/movie11.jpg", "This is Songoku2 Product", "link clip", "Songoku2", 5 },
                    { "fcc88cb5-c35d-4f37-aa64-29b59a685569", "css/images/movie9.jpg", "This is Yêu Thần Ký Product", "link clip", "Yêu Thần Ký", 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ProductTypeId", "ProductTypeName" },
                values: new object[,]
                {
                    { "a63b56d5-a452-479b-bc1f-3491a457843b", "Romantic" },
                    { "ca15d04c-3f00-49ae-a52b-36b744975b5f", "Action" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "60dbae58-6973-4c69-8f94-c3607a7f11ea", "Admin", "AppRole", "Admin", "admin" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "a6ce7349-1579-4eed-8059-bca10bed8608", "Staff", "AppRole", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserDoB", "UserFirstName", "UserLastName", "UserName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "b36d4d58-0716-4433-b2cd-682a11e4bdda", "AppUser", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPynoeqepuO0seiT3OzW7eIxD4ViSq3hfnoyDSx5KWF0sGq7gLfJAST9mJmCq2iAUg==", null, false, "a7036b45-5297-428a-9ea8-ad364a99c859", false, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin first name", "admin last name", "Admin", "08658568790" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "079d0cc4-87b7-4532-9147-32476bded111", "AppUser", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEHkspTmHWtl/E74vI+AcmOG7Pp/dHSxQWP+CzkM/FTFu0zS8nrM1UwJFGAG75g8FUQ==", null, false, "3e417764-9aa6-4d8e-a86f-68a4daed76ef", false, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff first name", "staff last name", "Staff", "08658568790" }
                });

            migrationBuilder.InsertData(
                table: "ProductInProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { "014479ad-ed74-4eda-8050-5e747072c9ae", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "2891735f-2709-4607-bd72-0cb9c5f3a7e7", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "6101c876-00a5-4d1f-9c1f-71673f5e1874", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "a9bd868f-199b-49bf-8af8-7ac43a91cd32", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "b93bbc67-d8eb-4663-bd42-e684e68a616a", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "e5e2300e-4ee6-4a3c-b9e8-b8cb9b7dc539", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "e9583c8a-bd6f-4a70-8264-a117b42029f0", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "fcc88cb5-c35d-4f37-aa64-29b59a685569", "a63b56d5-a452-479b-bc1f-3491a457843b" },
                    { "1169072a-954e-4e9c-a266-b55b62993194", "ca15d04c-3f00-49ae-a52b-36b744975b5f" },
                    { "124d8f9b-dffe-4da2-9664-bb0a7d83f81d", "ca15d04c-3f00-49ae-a52b-36b744975b5f" },
                    { "66f3ce30-ae63-40d6-b156-c8c077016552", "ca15d04c-3f00-49ae-a52b-36b744975b5f" },
                    { "775bc0bb-178d-40d1-8d80-509871237ab4", "ca15d04c-3f00-49ae-a52b-36b744975b5f" },
                    { "97cea438-1e6e-45f2-8ecd-158e9f951f5c", "ca15d04c-3f00-49ae-a52b-36b744975b5f" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInProductType_ProductId",
                table: "ProductInProductType",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInProductType");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
