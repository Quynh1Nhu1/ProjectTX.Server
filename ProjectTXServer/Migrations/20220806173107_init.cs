using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTXServer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenderType",
                columns: table => new
                {
                    GenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderType", x => x.GenderId);
                });

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
                name: "ProductInGender",
                columns: table => new
                {
                    GenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInGender", x => new { x.GenderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInGender_GenderType_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderType",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInGender_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
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
                table: "GenderType",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[,]
                {
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "Man" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "Women" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "ProductCover", "ProductDescription", "ProductIntro", "ProductName", "ProductRate" },
                values: new object[,]
                {
                    { "01eb7d27-cf08-4fc8-a8ea-99d9c9aa122e", "css/images/product_women7.PNG", "This is women7", "link clip", "women7", 5 },
                    { "09df7447-8d67-4aba-96bd-1878da562790", "css/images/product_women2.PNG", "This is women2", "link clip", "women2", 5 },
                    { "0d94d990-ee7e-41b3-9dee-c4e79ab0127e", "css/images/product_pantmen1.PNG", "This is pantman1", "link clip", "pantman1", 5 },
                    { "3837b416-4a88-4919-b51f-9e27c5cc2d46", "css/images/product_men10.PNG", "That is Astronaut", "link clip", "Astronaut", 5 },
                    { "45b2df55-4c1d-4fec-99ee-0f87dd5bc6d4", "css/images/product_men6.PNG", "Make in china", "link clip", "T shirt for men", 5 },
                    { "553f45a0-c3a5-418c-b70b-6068ce26d35e", "css/images/product_pantwomen4.PNG", "This is pantwoman4", "link clip", "pantwoman4", 5 },
                    { "59b54478-7b46-4e7e-8897-286eee9ff598", "css/images/product_pantwomen3.PNG", "This is pantwoman3", "link clip", "pantwoman3", 5 },
                    { "5ff68ca4-7d71-485d-b5b2-1da4015fc6bc", "css/images/product_men5.PNG", "This is Unifas", "link clip", "Unifas", 5 },
                    { "62c5c6a2-f811-4b8f-8945-fa23466e1f89", "css/images/product_pantmen3.PNG", "This is pantman3", "link clip", "pantman3", 5 },
                    { "6d82c892-ddb6-4fad-be13-d949626fa168", "css/images/product_men3.PNG", "The King man T shirt make by coton", "link clip", "King man T shirt", 3 },
                    { "7a2a95ff-4cd4-4ad1-88bc-a192a88d17e8", "css/images/product_pantmen2.PNG", "This is pantman2", "link clip", "pantman2", 5 },
                    { "86bcfb4f-8134-453c-b325-6dfdc9b8a9e3", "css/images/product_pantmen5.PNG", "This is pantman5", "link clip", "pantman5", 5 },
                    { "98ea05ce-290a-47e4-9305-8f6d63bf146f", "css/images/product_men8.PNG", "T-shirt smile, that is the best for you", "link clip", "T-shirt smile", 5 },
                    { "a38f3b3e-7819-4703-b0e2-89bc781a230d", "css/images/product_men7.PNG", "This is YourName Product", "link clip", "YourName", 5 },
                    { "b04d39cc-b017-4531-b5aa-4e5fc9be7e85", "css/images/product_men9.PNG", "True choise for guy", "link clip", "Magic T-shirt", 5 },
                    { "b26e8f39-9fd6-452d-ba78-3f0596a91161", "css/images/product_women3.PNG", "This is women3", "link clip", "women3", 5 },
                    { "b50baaa2-e275-4e06-a383-2229170eaeab", "css/images/product_men4.PNG", "The Anti formalism T-shirt for men", "link clip", "Anti formalism", 3 },
                    { "b52851fd-4f18-460b-bb88-ad394f555a97", "css/images/product_women4.PNG", "This is women4", "link clip", "women4", 5 },
                    { "b7373d44-a780-4dc2-8454-e26f23a39555", "css/images/product_women6.PNG", "This is women6", "link clip", "women6", 5 },
                    { "c0477977-86f0-4c86-9918-36248dae7909", "css/images/product_pantwomen1.PNG", "This is pantwoman1", "link clip", "pantwoman1", 5 },
                    { "c3e9c916-b097-4bc0-bad5-396ddd26380f", "css/images/product_women9.PNG", "This is women9", "link clip", "women9", 5 },
                    { "cc9f6991-c49b-490d-b45f-6f59871a007b", "css/images/product_women5.PNG", "This is women5", "link clip", "women5", 5 },
                    { "d7cb1572-c3bc-4d14-b3fd-9f0314e842c3", "css/images/product_men1.PNG", "This is BST Product", "link clip", "The Astronut", 1 },
                    { "df494828-5e70-45d9-8ebc-5ab49c7fa572", "css/images/product_pantwomen5.PNG", "This is pantwoman5", "link clip", "pantwoman5", 5 },
                    { "e36ce996-b97a-476b-805e-96e3ba429c01", "css/images/product_men2.PNG", "Men T-shirt The Astronut", "link clip", "BST Summer T-shirt", 1 },
                    { "e3fb0395-30d1-4bab-8de0-85519ccf972e", "css/images/product_pantmen4.PNG", "This is pantman4", "link clip", "pantman4", 5 },
                    { "e7631d91-090a-4b76-8f23-80e0a387e474", "css/images/product_pantwomen2.PNG", "This is pantwoman2", "link clip", "pantwoman2", 5 },
                    { "f0a55fb4-5de8-4e30-8cb3-76d2006778fc", "css/images/product_women10.PNG", "This is women10", "link clip", "women10", 5 },
                    { "f5a00158-ce62-4ba7-ae94-ee48d6f81057", "css/images/product_women8.PNG", "This is women8", "link clip", "women8", 5 },
                    { "fa983979-a9d6-4e2f-acc5-57825e7bb28b", "css/images/product_women1.PNG", "Headsfer T-shirt for women1 have a passion with SWAG", "link clip", "women1", 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ProductTypeId", "ProductTypeName" },
                values: new object[,]
                {
                    { "036774b2-9a3a-43a4-bf2e-6201b00fb9c4", "Shirt" },
                    { "5be64913-28eb-473c-96b6-9c6239fc1c58", "Pants" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "4b21e314-9e7e-42df-963e-81918a79ddd6", "Admin", "AppRole", "Admin", "admin" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "c09aba0b-808a-4db9-a68f-22d3b94dd17c", "Staff", "AppRole", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserDoB", "UserFirstName", "UserLastName", "UserName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "70287441-de7a-42e0-a6cc-1ed9dd1454d6", "AppUser", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJbW3JFE+keC3X8LGih9ZswjqqzsmSuqBQ68G1TrZ6FZUnhP7TI+9T1P2r8cznN9Og==", null, false, "b37b56d0-3679-490c-8045-9611d5c6504f", false, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin first name", "admin last name", "Admin", "08658568790" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "f0d3568d-2e28-46a2-8bd0-033907897252", "AppUser", "staff@gmail.com", true, false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEMWbI5yfEoPHOD0gdjbiT1gA0Tpq52yA3fXsiYEESIukCa0rgTi8l4NjkWkqFxTnEw==", null, false, "53053ae9-03ad-494e-a25a-b0552d7f130a", false, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff first name", "staff last name", "Staff", "08658568790" }
                });

            migrationBuilder.InsertData(
                table: "ProductInGender",
                columns: new[] { "GenderId", "ProductId" },
                values: new object[,]
                {
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "0d94d990-ee7e-41b3-9dee-c4e79ab0127e" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "3837b416-4a88-4919-b51f-9e27c5cc2d46" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "45b2df55-4c1d-4fec-99ee-0f87dd5bc6d4" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "5ff68ca4-7d71-485d-b5b2-1da4015fc6bc" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "62c5c6a2-f811-4b8f-8945-fa23466e1f89" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "6d82c892-ddb6-4fad-be13-d949626fa168" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "7a2a95ff-4cd4-4ad1-88bc-a192a88d17e8" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "86bcfb4f-8134-453c-b325-6dfdc9b8a9e3" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "98ea05ce-290a-47e4-9305-8f6d63bf146f" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "a38f3b3e-7819-4703-b0e2-89bc781a230d" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "b04d39cc-b017-4531-b5aa-4e5fc9be7e85" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "b50baaa2-e275-4e06-a383-2229170eaeab" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "d7cb1572-c3bc-4d14-b3fd-9f0314e842c3" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "e36ce996-b97a-476b-805e-96e3ba429c01" },
                    { "120da95c-d18c-4ef3-b921-1561af4e3ac2", "e3fb0395-30d1-4bab-8de0-85519ccf972e" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "01eb7d27-cf08-4fc8-a8ea-99d9c9aa122e" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "09df7447-8d67-4aba-96bd-1878da562790" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "553f45a0-c3a5-418c-b70b-6068ce26d35e" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "59b54478-7b46-4e7e-8897-286eee9ff598" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "b26e8f39-9fd6-452d-ba78-3f0596a91161" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "b52851fd-4f18-460b-bb88-ad394f555a97" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "b7373d44-a780-4dc2-8454-e26f23a39555" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "c0477977-86f0-4c86-9918-36248dae7909" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "c3e9c916-b097-4bc0-bad5-396ddd26380f" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "cc9f6991-c49b-490d-b45f-6f59871a007b" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "df494828-5e70-45d9-8ebc-5ab49c7fa572" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "e7631d91-090a-4b76-8f23-80e0a387e474" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "f0a55fb4-5de8-4e30-8cb3-76d2006778fc" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "f5a00158-ce62-4ba7-ae94-ee48d6f81057" },
                    { "9156d3b1-14ef-4978-bf5e-c90a29ec057d", "fa983979-a9d6-4e2f-acc5-57825e7bb28b" }
                });

            migrationBuilder.InsertData(
                table: "ProductInProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { "01eb7d27-cf08-4fc8-a8ea-99d9c9aa122e", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "09df7447-8d67-4aba-96bd-1878da562790", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "3837b416-4a88-4919-b51f-9e27c5cc2d46", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "45b2df55-4c1d-4fec-99ee-0f87dd5bc6d4", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "5ff68ca4-7d71-485d-b5b2-1da4015fc6bc", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "6d82c892-ddb6-4fad-be13-d949626fa168", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "98ea05ce-290a-47e4-9305-8f6d63bf146f", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "a38f3b3e-7819-4703-b0e2-89bc781a230d", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "b04d39cc-b017-4531-b5aa-4e5fc9be7e85", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "b26e8f39-9fd6-452d-ba78-3f0596a91161", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "b50baaa2-e275-4e06-a383-2229170eaeab", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "b52851fd-4f18-460b-bb88-ad394f555a97", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" }
                });

            migrationBuilder.InsertData(
                table: "ProductInProductType",
                columns: new[] { "ProductId", "ProductTypeId" },
                values: new object[,]
                {
                    { "b7373d44-a780-4dc2-8454-e26f23a39555", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "c3e9c916-b097-4bc0-bad5-396ddd26380f", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "cc9f6991-c49b-490d-b45f-6f59871a007b", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "d7cb1572-c3bc-4d14-b3fd-9f0314e842c3", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "e36ce996-b97a-476b-805e-96e3ba429c01", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "f0a55fb4-5de8-4e30-8cb3-76d2006778fc", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "f5a00158-ce62-4ba7-ae94-ee48d6f81057", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "fa983979-a9d6-4e2f-acc5-57825e7bb28b", "036774b2-9a3a-43a4-bf2e-6201b00fb9c4" },
                    { "0d94d990-ee7e-41b3-9dee-c4e79ab0127e", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "553f45a0-c3a5-418c-b70b-6068ce26d35e", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "59b54478-7b46-4e7e-8897-286eee9ff598", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "62c5c6a2-f811-4b8f-8945-fa23466e1f89", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "7a2a95ff-4cd4-4ad1-88bc-a192a88d17e8", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "86bcfb4f-8134-453c-b325-6dfdc9b8a9e3", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "c0477977-86f0-4c86-9918-36248dae7909", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "df494828-5e70-45d9-8ebc-5ab49c7fa572", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "e3fb0395-30d1-4bab-8de0-85519ccf972e", "5be64913-28eb-473c-96b6-9c6239fc1c58" },
                    { "e7631d91-090a-4b76-8f23-80e0a387e474", "5be64913-28eb-473c-96b6-9c6239fc1c58" }
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
                name: "IX_ProductInGender_ProductId",
                table: "ProductInGender",
                column: "ProductId");

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
                name: "ProductInGender");

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
                name: "GenderType");

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
