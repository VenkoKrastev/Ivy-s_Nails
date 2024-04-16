using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IvysNails.Infrastructure.Migrations
{
    public partial class AllNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The current user's Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The current Category's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "The Name of product category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The current Service Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "The name of the service"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "The price of current service")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The current Product's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of product"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false, comment: "The current Products Price"),
                    StockQuantity = table.Column<int>(type: "int", nullable: false, comment: "Available quantity of the product"),
                    Details = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: false, comment: "Product details"),
                    ImageUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "The current picture of product"),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The current Product's Identifier"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => new { x.ServiceId, x.CustomerId });
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCarts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "The current Product's Identifier"),
                    CartId = table.Column<int>(type: "int", nullable: false, comment: "The current Cart's Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCarts", x => new { x.ProductId, x.CartId });
                    table.ForeignKey(
                        name: "FK_ProductCarts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "e0d13875-3842-4861-9c60-62f5e9b1665b", "guest@gmail.com", false, false, null, "GUEST@GMAIL.COM", "GUEST@GMAIL.COM", "AQAAAAEAACcQAAAAEL1u/JLtr9IsiepHIOBPgSs4tJEIlQJplcwFzrxfQfysXUNwiNxR8paSgvZkDEvPRw==", null, false, "25364add-0c08-4d74-b9ae-cdd431ac19a4", false, "guest@gmail.com" },
                    { "c2f14bf7-ffdd-47a4-90b3-f2309486fae9", 0, "3d4e4949-3992-4eda-8ef4-c05e1e03ef3f", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIJfddgEFymUaTS0+SZIaeqcTSX6IYjHcGgq+5n1lZ3JpdZ3WlOkkbYiIr7u0+YaaA==", null, false, "a568a66a-d5d8-40ef-8c81-41ef7a79cf48", false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Шампоан" },
                    { 2, "Лак за коса" },
                    { 3, "Лак за нокти" },
                    { 4, "Боя за коса" },
                    { 5, "Пила за нокти" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Лакиране с обикновен лак", 20.00m },
                    { 2, "Изграждане на нокти", 80.00m },
                    { 3, "Лакиране с гел лаk", 35.00m },
                    { 4, "Мъжки маникюр", 20.00m },
                    { 5, "Педикюр", 50.00m },
                    { 6, "медицински педикюр", 80.00m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Details", "ImageUrl", "Name", "Price", "ProductCategoryId", "StockQuantity" },
                values: new object[,]
                {
                    { 1, "Реконструиращ шампоан за слаба и безжизнена коса 250 мл", "https://www.google.com/imgres?q=%D1%88%D0%B0%D0%BC%D0%BF%D0%BE%D0%B0%D0%BD%20%D0%B7%D0%B0%20%D0%BA%D0%BE%D1%81%D0%B0&imgurl=https%3A%2F%2Fwww.zlatnaribka.com%2Fimage%2Fcache%2Fcatalog%2F2019_Products_Pictures%2FKerastase%2FForce%2520Architecte%2FKerastase-Bain-Force-Architecte-shampoo-700-min-700x700.jpg&imgrefurl=http%3A%2F%2Fwww.zlatnaribka.com%2Fshampoan-za-silno-iztoshtena-i-nakasana-kosa-kerastase-bain-force-architecte-250-ml&docid=Fvk3PocZCYyuUM&tbnid=JtJ_86AoJVrdUM&vet=12ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECG0QAA..i&w=700&h=700&hcb=2&ved=2ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECG0QAA", "KERASTASE", 58.00m, 1, 9 },
                    { 2, "Подходящ за боядисана или коса на кичури. Предпазва интензивността на цвета и го защитава от избледняване. Косата е здрава, лъскава и сияйна", "https://www.google.com/imgres?q=%D1%88%D0%B0%D0%BC%D0%BF%D0%BE%D0%B0%D0%BD%20%D0%B7%D0%B0%20%D0%BA%D0%BE%D1%81%D0%B0&imgurl=https%3A%2F%2Fgalen.bg%2Fmedia%2Fcatalog%2Fproduct%2Fcache%2F4587ace2ea33d73df121dcde1c6b054a%2F5%2F2-45491-29207%2Fsyoss-color-750-.jpg&imgrefurl=https%3A%2F%2Fgalen.bg%2Fsayas-shampoan-zashtita-na-tsveta-750ml&docid=2D0jEJAd2JKyoM&tbnid=CbN5yHRdk-GWxM&vet=12ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECGsQAA..i&w=700&h=700&hcb=2&ved=2ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECGsQAA", "SYOSS", 13.90m, 1, 20 },
                    { 3, "Цвят: Сияйно фуксия-розово. Fuchsia in Love L'Oxygéné от Nailberry внася в живота ви сияйна цветна радост и подсилва всяко облекло със своя сияен цвят. Брилянтният лилаво-розов нюанс може да се нанася без усилие и без ивици, с особено дълготраен резултат. Гамата лакове за нокти L'Oxygéné използва патентована технология, насочена към по-здравословна форма на маникюр. Резултатът е дишащи, водопропускливи и съдържащи кислород лакове, които са особено нежни към ноктите ви.Продуктът е веганнски, без тестове с животни и халал и без глутен.", "https://www.google.com/imgres?q=%D0%BB%D0%B0%D0%BA%20%D0%B7%D0%B0%20%D0%BD%D0%BE%D0%BA%D1%82%D0%B8&imgurl=https%3A%2F%2Fco.nice-cdn.com%2Fupload%2Fimage%2Fproduct%2Flarge%2Fdefault%2Fnailberry-lak-za-nokti-fuchsia-in-love-loxygene-15-ml-447434-bg.jpg&imgrefurl=https%3A%2F%2Fwww.cosmeterie.bg%2Fnailberry%2Flak-za-nokti-fuchsia-in-love-loxygene&docid=_uoZbQhPXkWwjM&tbnid=jLTDHbnIasedpM&vet=12ahUKEwiQq7Pm_8GFAxVIQfEDHblaDtwQM3oECG4QAA..i&w=1920&h=1920&hcb=2&ved=2ahUKEwiQq7Pm_8GFAxVIQfEDHblaDtwQM3oECG4QAA", "NAILBERRY", 42.09m, 3, 7 },
                    { 4, "Права диамантена пила за нокти. Двустранна - едра и финна. Бяла пластмасова дръжка. Обща дължина: 9 см / 3.5 инча. Дължина острие: 5.5 см", "https://www.google.com/imgres?q=%D0%BF%D0%B8%D0%BB%D0%B0%20%D0%B7%D0%B0%20%D0%BD%D0%BE%D0%BA%D1%82%D0%B8&imgurl=https%3A%2F%2F2styrkela.com%2Fmedia%2Fcatalog%2Fproduct%2Fcache%2F1%2Fimage%2F9df78eab33525d08d6e5fb8d27136e95%2Fn%2Fi%2Fniegeloh-solingen_diamantena-pila-za-nokti_20421_3.jpg&imgrefurl=https%3A%2F%2F2styrkela.com%2Fpila-za-nokti-niegeloh-solingen-20421-13455.html&docid=ocZ1gRNnQXuHWM&tbnid=DijUBYehVscKSM&vet=12ahUKEwjzkJySgcKFAxVeBdsEHalVBbAQM3oECBUQAA..i&w=515&h=450&hcb=2&ved=2ahUKEwjzkJySgcKFAxVeBdsEHalVBbAQM3oECBUQAA", "Niegeloh Solingen", 5.60m, 5, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerId",
                table: "Appointments",
                column: "CustomerId");

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
                name: "IX_ProductCarts_CartId",
                table: "ProductCarts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

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
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductCarts");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
