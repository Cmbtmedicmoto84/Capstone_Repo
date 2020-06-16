using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Data.Migrations
{
    public partial class secondAttemptAfterDbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "023de30e-5a89-4087-99a2-a193750c11a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fd114d0-d8b3-430a-8a58-835319fc48f0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7c2274a-e664-42b6-9b0a-68e732de10e2", "cc17e25a-d647-4041-bdaf-11ce31d76d2f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c4b53b2-1909-493f-8e70-cd5208e4c722", "466d2a29-431c-47f0-adc0-f6fe41df0953", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c4b53b2-1909-493f-8e70-cd5208e4c722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7c2274a-e664-42b6-9b0a-68e732de10e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "023de30e-5a89-4087-99a2-a193750c11a0", "e72acda5-1742-4528-9ff6-1c9a968b30d1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fd114d0-d8b3-430a-8a58-835319fc48f0", "83408930-9156-4a48-b2f3-8b134fed1e9d", "Employee", "EMPLOYEE" });
        }
    }
}
