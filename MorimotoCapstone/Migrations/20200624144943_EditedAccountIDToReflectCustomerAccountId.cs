using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class EditedAccountIDToReflectCustomerAccountId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a3e7516-7ca9-42c7-8ce3-6aeeb125c27e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c612f893-a042-43ee-b56c-e32960dfa2b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c70d6278-5667-417a-b4aa-5c5c1ebe3539");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountId",
                table: "Customers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerAccountId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca63b1af-ebcc-4b67-b412-68cec3d5655d", "4c9d2f07-a64a-46d6-819a-8746484463c5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1067590b-d9df-4f5e-b43b-fd061e14bd57", "4a6c6f03-2b5a-4acb-b82f-11d91bbdcdae", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5199cadc-e7b2-45b7-ae99-7b0e93463846", "ffe68c4e-f5a7-4dcd-868d-ce208de3c182", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1067590b-d9df-4f5e-b43b-fd061e14bd57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5199cadc-e7b2-45b7-ae99-7b0e93463846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca63b1af-ebcc-4b67-b412-68cec3d5655d");

            migrationBuilder.DropColumn(
                name: "CustomerAccountId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "AccountNumber",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "AccountNumber");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a3e7516-7ca9-42c7-8ce3-6aeeb125c27e", "41cc4155-c79a-4903-b463-a96eb3db0916", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c612f893-a042-43ee-b56c-e32960dfa2b4", "296aa04b-c388-4a1b-90d5-6cc56306ae84", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c70d6278-5667-417a-b4aa-5c5c1ebe3539", "55e15aec-f0ed-43f8-abe4-b6b2a0c7dba4", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
