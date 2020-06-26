using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class WorkingOnAddingTwilioAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acfb747d-b5f5-46ca-9fc0-7bec25ad7254");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8950213-558a-4ea0-ae08-eb272a99bb34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "babddecf-a9c7-4fd8-88cb-80fc36f02f17");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Timezone = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd4c6036-519c-4a66-b6c3-cecd9faf471f", "1f5035a5-ee87-4937-8688-5db3cc2219b0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffd3f73a-2e5f-4d33-96b7-4d676d6ccf36", "44d98258-7102-443d-a448-4d66cedebfc8", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f44d6b9-5ef9-48c1-aa40-c320e5d17ece", "f5692b01-df43-4f4e-8590-9992675468cf", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f44d6b9-5ef9-48c1-aa40-c320e5d17ece");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd4c6036-519c-4a66-b6c3-cecd9faf471f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd3f73a-2e5f-4d33-96b7-4d676d6ccf36");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8950213-558a-4ea0-ae08-eb272a99bb34", "9a9a618d-ac9b-4bf4-ae0c-9c7dcdd3d478", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "babddecf-a9c7-4fd8-88cb-80fc36f02f17", "9cfc3079-056e-44da-951e-89904ce5325d", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acfb747d-b5f5-46ca-9fc0-7bec25ad7254", "03cd9209-1d31-4802-88f8-de378970010b", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
