using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class editedCSRId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerServiceReps",
                table: "CustomerServiceReps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14b49076-264c-4da8-b769-80ce7242279c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e9e5998-5f79-46ec-9260-a087fada2eb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2daeacf-8040-4fd2-9e10-19f7536989cc");

            migrationBuilder.DropColumn(
                name: "CustomerServiceId",
                table: "CustomerServiceReps");

            migrationBuilder.AddColumn<int>(
                name: "CustomerServiceRepId",
                table: "CustomerServiceReps",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerServiceReps",
                table: "CustomerServiceReps",
                column: "CustomerServiceRepId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "290ee8ab-4609-413d-a99a-c224a1378c51", "6215226f-04c0-4bce-98db-4274d6ae831c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce4a801a-a86f-4c7c-b3e3-fb5e9b3e1e67", "2dae9b6d-80c7-4410-b73c-0dbabb91dbc3", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df8d5145-8de3-41c0-a13c-4c59141804bc", "cfa7b8bc-05f9-4e8e-9769-cf55772488a2", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerServiceReps",
                table: "CustomerServiceReps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "290ee8ab-4609-413d-a99a-c224a1378c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce4a801a-a86f-4c7c-b3e3-fb5e9b3e1e67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df8d5145-8de3-41c0-a13c-4c59141804bc");

            migrationBuilder.DropColumn(
                name: "CustomerServiceRepId",
                table: "CustomerServiceReps");

            migrationBuilder.AddColumn<int>(
                name: "CustomerServiceId",
                table: "CustomerServiceReps",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerServiceReps",
                table: "CustomerServiceReps",
                column: "CustomerServiceId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14b49076-264c-4da8-b769-80ce7242279c", "7d81af41-1cfe-4b9f-88fe-33f4ac7a2ba1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2daeacf-8040-4fd2-9e10-19f7536989cc", "7df8a748-8b98-4db5-8287-1b5b5a032fca", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e9e5998-5f79-46ec-9260-a087fada2eb6", "02f13fa3-c59f-499d-a0d7-127406aea696", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
