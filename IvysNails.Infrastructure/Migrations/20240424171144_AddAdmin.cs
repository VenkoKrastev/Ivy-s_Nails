using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IvysNails.Infrastructure.Migrations
{
    public partial class AddAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34e926f7-14c6-490b-b4a6-2781902e3e06", "Guest", "Guestov", "AQAAAAEAACcQAAAAEI2oZBSuWApgd/MbXqgmwY5ZogfMgWWgA084zmQCA+/6PkqLISiTUtrPWhcKKdQmpQ==", "e7b85388-f1ed-495d-aedd-a290c4a605eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffc3700d-be82-4f05-a4ce-f2b4ec345683", "Admincho", "Adminov", "AQAAAAEAACcQAAAAECSN2zF9fOUo2lGk4gUPsymQh7Yv8+puZgjaREfNXknZwop47VWY638ViwCzp1I8ow==", "7141d881-674e-4f03-b933-a3082af1055c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
        }
    }
}
