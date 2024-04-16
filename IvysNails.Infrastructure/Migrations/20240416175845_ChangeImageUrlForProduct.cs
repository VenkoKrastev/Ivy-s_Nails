using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IvysNails.Infrastructure.Migrations
{
    public partial class ChangeImageUrlForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b8e6c1a-7ee4-48a1-9479-a06271cd4a49", "AQAAAAEAACcQAAAAEOaiil6uJv1SoZgoIbNr4VWRI/ztz7Md6hu1kVuKYc3wbG1SeM05chCbGwih7KXkzg==", "cc942dd6-496d-4b07-b34e-bee5e2dea007" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dbf05ae-4a08-4847-90c1-c83382b9995f", "AQAAAAEAACcQAAAAEOSMygKJNNHPRnK92W+fbIiRnThv3XuljcKuhk3GMbXwyP7wQYdRve6l62DgkmxFFg==", "732c2a06-e8d4-4f86-8053-68bc596a2d43" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://nstage.bg/product/resistance-bain-force-architecte-shampoo/#&gid=1&pid=1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://galen.bg/sayas-shampoan-zashtita-na-tsveta-750ml");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://co.nice-cdn.com/upload/image/product/large/default/nailberry-lak-za-nokti-fuchsia-in-love-loxygene-15-ml-447434-bg.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://zasalona.com/za-kozmetika/abrazivi/solingen-17");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0d13875-3842-4861-9c60-62f5e9b1665b", "AQAAAAEAACcQAAAAEL1u/JLtr9IsiepHIOBPgSs4tJEIlQJplcwFzrxfQfysXUNwiNxR8paSgvZkDEvPRw==", "25364add-0c08-4d74-b9ae-cdd431ac19a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d4e4949-3992-4eda-8ef4-c05e1e03ef3f", "AQAAAAEAACcQAAAAEIJfddgEFymUaTS0+SZIaeqcTSX6IYjHcGgq+5n1lZ3JpdZ3WlOkkbYiIr7u0+YaaA==", "a568a66a-d5d8-40ef-8c81-41ef7a79cf48" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/imgres?q=%D1%88%D0%B0%D0%BC%D0%BF%D0%BE%D0%B0%D0%BD%20%D0%B7%D0%B0%20%D0%BA%D0%BE%D1%81%D0%B0&imgurl=https%3A%2F%2Fwww.zlatnaribka.com%2Fimage%2Fcache%2Fcatalog%2F2019_Products_Pictures%2FKerastase%2FForce%2520Architecte%2FKerastase-Bain-Force-Architecte-shampoo-700-min-700x700.jpg&imgrefurl=http%3A%2F%2Fwww.zlatnaribka.com%2Fshampoan-za-silno-iztoshtena-i-nakasana-kosa-kerastase-bain-force-architecte-250-ml&docid=Fvk3PocZCYyuUM&tbnid=JtJ_86AoJVrdUM&vet=12ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECG0QAA..i&w=700&h=700&hcb=2&ved=2ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECG0QAA");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.google.com/imgres?q=%D1%88%D0%B0%D0%BC%D0%BF%D0%BE%D0%B0%D0%BD%20%D0%B7%D0%B0%20%D0%BA%D0%BE%D1%81%D0%B0&imgurl=https%3A%2F%2Fgalen.bg%2Fmedia%2Fcatalog%2Fproduct%2Fcache%2F4587ace2ea33d73df121dcde1c6b054a%2F5%2F2-45491-29207%2Fsyoss-color-750-.jpg&imgrefurl=https%3A%2F%2Fgalen.bg%2Fsayas-shampoan-zashtita-na-tsveta-750ml&docid=2D0jEJAd2JKyoM&tbnid=CbN5yHRdk-GWxM&vet=12ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECGsQAA..i&w=700&h=700&hcb=2&ved=2ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECGsQAA");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.google.com/imgres?q=%D0%BB%D0%B0%D0%BA%20%D0%B7%D0%B0%20%D0%BD%D0%BE%D0%BA%D1%82%D0%B8&imgurl=https%3A%2F%2Fco.nice-cdn.com%2Fupload%2Fimage%2Fproduct%2Flarge%2Fdefault%2Fnailberry-lak-za-nokti-fuchsia-in-love-loxygene-15-ml-447434-bg.jpg&imgrefurl=https%3A%2F%2Fwww.cosmeterie.bg%2Fnailberry%2Flak-za-nokti-fuchsia-in-love-loxygene&docid=_uoZbQhPXkWwjM&tbnid=jLTDHbnIasedpM&vet=12ahUKEwiQq7Pm_8GFAxVIQfEDHblaDtwQM3oECG4QAA..i&w=1920&h=1920&hcb=2&ved=2ahUKEwiQq7Pm_8GFAxVIQfEDHblaDtwQM3oECG4QAA");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.google.com/imgres?q=%D0%BF%D0%B8%D0%BB%D0%B0%20%D0%B7%D0%B0%20%D0%BD%D0%BE%D0%BA%D1%82%D0%B8&imgurl=https%3A%2F%2F2styrkela.com%2Fmedia%2Fcatalog%2Fproduct%2Fcache%2F1%2Fimage%2F9df78eab33525d08d6e5fb8d27136e95%2Fn%2Fi%2Fniegeloh-solingen_diamantena-pila-za-nokti_20421_3.jpg&imgrefurl=https%3A%2F%2F2styrkela.com%2Fpila-za-nokti-niegeloh-solingen-20421-13455.html&docid=ocZ1gRNnQXuHWM&tbnid=DijUBYehVscKSM&vet=12ahUKEwjzkJySgcKFAxVeBdsEHalVBbAQM3oECBUQAA..i&w=515&h=450&hcb=2&ved=2ahUKEwjzkJySgcKFAxVeBdsEHalVBbAQM3oECBUQAA");
        }
    }
}
