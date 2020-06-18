using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class seedingInProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6972fcb2-0a6e-4e25-b7c0-8360392be8ae", "bbc0e782-85e4-4cba-bcdb-47f182e68be0", "Customer", "CUSTOMER" },
                    { "f78d3d26-7cfd-448c-9c9f-a771d751ec88", "925407c1-1dd0-481f-a0f0-42cd73a95ff9", "InstallTech", "INSTALLTECH" },
                    { "867d9e54-34b5-4c83-a3bc-d0d00e970e29", "c106dc83-9131-41ad-b326-f7467bdb2bdb", "CustomerServiceRep", "CUSTOMERSERVICEREP" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 12, "Our fastest Internet with syncronous Up/Down speeds of 1 Gig!!", "Ultra-Fast Internet", 59.990000000000002 },
                    { 22, "Fast internet with Up/Down speeds of 300Mbps!", "Fast Internet", 39.990000000000002 },
                    { 32, "Basic fiber internet speeds of up to 100Mbps!", "Standard Internet", 24.989999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6972fcb2-0a6e-4e25-b7c0-8360392be8ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "867d9e54-34b5-4c83-a3bc-d0d00e970e29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f78d3d26-7cfd-448c-9c9f-a771d751ec88");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

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
    }
}
