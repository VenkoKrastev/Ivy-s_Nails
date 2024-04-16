using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IvysNails.Data.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customer_CustomerId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategory_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductsCarts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                comment: "The current picture of product",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "The current picture of product");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Products",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                comment: "Product details",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "Product details");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                comment: "The current user's Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "The current user's Identifier");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "The current User's Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ProductCarts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "The current Book's Identifier"),
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "261921bd-6f66-4c3f-acbc-442f68273b14", "guest@gmail.com", false, false, null, "GUEST@GMAIL.COM", "GUEST@GMAIL.COM", "AQAAAAEAACcQAAAAENqVevKtLVij3N9rnEw3yRLrb5e0aMHrmoDRTJowcgSPVs40IHUXQlGiI06/bARPNA==", null, false, "fcb06f61-f87b-4bd6-ac39-385bf78ead46", false, "guest@gmail.com" },
                    { "c2f14bf7-ffdd-47a4-90b3-f2309486fae9", 0, "ec88c20c-4624-452a-8dec-84d7f87e984f", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBrmY7BWKdxo+1cTbOAp6OlkI/dNsMPy0M+ZAQycparvh9363HpTRClP1Vs4DXuCnw==", null, false, "f5933ffa-2d5b-4ecd-9b2f-89b864ff7e66", false, "admin@gmail.com" }
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
                name: "IX_ProductCarts_CartId",
                table: "ProductCarts",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_CustomerId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductCarts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "The current picture of product",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "The current picture of product");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "Product details",
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldComment: "Product details");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                comment: "The current user's Identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The current user's Identifier");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Carts",
                type: "int",
                nullable: false,
                comment: "The current User's Identifier",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The current Category's Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "The Name of product category")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsCarts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false, comment: "The current Book's Identifier"),
                    CartId = table.Column<int>(type: "int", nullable: false, comment: "The current Cart's Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCarts", x => new { x.ProductId, x.CartId });
                    table.ForeignKey(
                        name: "FK_ProductsCarts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCarts_CartId",
                table: "ProductsCarts",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customer_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategory_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
