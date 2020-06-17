using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class editedCustomerModelAndViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cc2f2e2-35ae-4f51-8c67-02e85f478841");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36506ba6-ad55-4ebe-aaf9-75afd97d5ccc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "709d5d24-bbbb-43ec-90d1-8bf12274e7a2");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab561ffb-5e83-40ae-80c8-7168cb8efea3", "daa075da-1206-4548-9cf2-377c6e4723d3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a771f29e-1198-4a8b-a604-3d1b14801bbe", "a83a5198-acf0-4345-aa1c-5f67a9731885", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3898ee50-90fa-48e2-8c96-d908c079304c", "ed43c8b1-8fcd-484d-9402-0cbc30ba26ea", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3898ee50-90fa-48e2-8c96-d908c079304c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a771f29e-1198-4a8b-a604-3d1b14801bbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab561ffb-5e83-40ae-80c8-7168cb8efea3");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36506ba6-ad55-4ebe-aaf9-75afd97d5ccc", "f93467fd-7462-48fa-a778-13e8e58c91b4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "709d5d24-bbbb-43ec-90d1-8bf12274e7a2", "e046fbb8-e825-4f1b-8615-48556de66e90", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2cc2f2e2-35ae-4f51-8c67-02e85f478841", "79ee0004-046d-44e3-a6eb-e1abca8a8cc1", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
