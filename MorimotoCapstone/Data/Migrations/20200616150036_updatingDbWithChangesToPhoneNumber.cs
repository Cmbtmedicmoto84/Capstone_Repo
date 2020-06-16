using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Data.Migrations
{
    public partial class updatingDbWithChangesToPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a8f6be5-fb3c-42ea-bd05-bacc39c8471f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cb7a3ec-a09d-46ca-bf63-86785b850db1");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0924d8b-9a1d-4598-9ab0-6b663640fcd9", "69a42c98-2334-412b-a029-71d85305c0c3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "755ea837-6197-4e76-8839-9228ecf21269", "60144cd1-c498-4fd3-a106-ff6e609a4dff", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "755ea837-6197-4e76-8839-9228ecf21269");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0924d8b-9a1d-4598-9ab0-6b663640fcd9");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a8f6be5-fb3c-42ea-bd05-bacc39c8471f", "5cfda567-b2cf-4db0-8364-dcb896dacf35", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cb7a3ec-a09d-46ca-bf63-86785b850db1", "735552c1-fd41-45ac-a516-1a60bd0265c3", "Employee", "EMPLOYEE" });
        }
    }
}
