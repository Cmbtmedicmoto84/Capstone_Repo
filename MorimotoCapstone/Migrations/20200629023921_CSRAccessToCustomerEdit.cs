using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class CSRAccessToCustomerEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ecab5f4-9fe8-44de-834c-ed00f141b181");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4633f02c-b2fe-40e5-a7ad-e825d57da9d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "806c23e8-fbd2-4c67-9bad-670797acf4a4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b8d936b-61c4-4b8f-a4f2-ca3103a32802", "079706c3-6f63-47ef-9369-97a38efc362c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19b30fb5-c392-4063-bf91-61d4fa28fd18", "42d3bf75-bdf1-4b5e-832b-873703181b62", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f55041eb-2ede-4585-a99e-88a1ecabf5c2", "38ee02b2-a950-46ed-ad7e-ea5851b1494c", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19b30fb5-c392-4063-bf91-61d4fa28fd18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b8d936b-61c4-4b8f-a4f2-ca3103a32802");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f55041eb-2ede-4585-a99e-88a1ecabf5c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ecab5f4-9fe8-44de-834c-ed00f141b181", "9506e806-b1e9-4b1f-b2e8-85e3ce5f8d1f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4633f02c-b2fe-40e5-a7ad-e825d57da9d5", "e83a5edf-0a4e-4ec3-8c63-fb888ffccde2", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "806c23e8-fbd2-4c67-9bad-670797acf4a4", "7870cde2-61c2-49ce-a203-ad5007be925d", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
