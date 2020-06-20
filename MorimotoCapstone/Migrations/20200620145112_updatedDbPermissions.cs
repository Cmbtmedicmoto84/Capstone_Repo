using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class updatedDbPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c06aadd-5944-429b-9621-08a549305490");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13dc5a5-5276-4923-b494-0790f5c848f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e32e8743-744b-46e9-8075-2d5a58c780c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "806ab74c-c920-4d11-8168-942c01ba3162", "e670735f-8f62-44e5-b742-6143e9128a49", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94ec509f-4ada-4ccc-b569-14dadb63e062", "a2792f6f-6957-43c9-85a0-2d752d2cf8d0", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65882cd6-7bf5-48ac-9eb6-f972ab70508b", "59c171a4-8fbc-4dfb-886e-5065b00440cb", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65882cd6-7bf5-48ac-9eb6-f972ab70508b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "806ab74c-c920-4d11-8168-942c01ba3162");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94ec509f-4ada-4ccc-b569-14dadb63e062");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e32e8743-744b-46e9-8075-2d5a58c780c9", "bf67571b-345c-4c33-94f0-224417bb06b8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c06aadd-5944-429b-9621-08a549305490", "c17b259d-3f41-454f-a061-41a4289d7790", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b13dc5a5-5276-4923-b494-0790f5c848f4", "243005c5-9689-4c05-a733-486e2ec06484", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
