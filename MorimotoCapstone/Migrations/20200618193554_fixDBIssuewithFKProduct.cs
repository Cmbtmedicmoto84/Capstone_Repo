using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class fixDBIssuewithFKProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Products_ProductId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ProductId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56211f84-e3f9-41fc-a6d8-a3b45b9c73c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d0a3898-0bc1-438c-a85d-2733fc5f064c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9b7091a-e2db-4600-959c-744dc5dad031");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44823322-9f9f-46b5-a5d9-065a18b88dd0", "ca3b5a6f-d791-4669-857e-37cca5740a29", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e75b0e0d-833f-4186-9b3f-a03b9eb3ea36", "c93582a0-122e-4ef5-8b28-2267494a2a03", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36f4bb3b-67bc-487f-b81e-915eae1f1477", "d3636148-97d6-4023-af5a-cc5fdb17d5e1", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36f4bb3b-67bc-487f-b81e-915eae1f1477");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44823322-9f9f-46b5-a5d9-065a18b88dd0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e75b0e0d-833f-4186-9b3f-a03b9eb3ea36");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e9b7091a-e2db-4600-959c-744dc5dad031", "b16f2975-b43d-474c-b0dd-af16c99d8ce2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d0a3898-0bc1-438c-a85d-2733fc5f064c", "4efb3391-6bce-4cac-a12e-870a58f02a92", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56211f84-e3f9-41fc-a6d8-a3b45b9c73c1", "defec6ab-ce3e-498c-899b-080456e8e983", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProductId",
                table: "Customers",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Products_ProductId",
                table: "Customers",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
