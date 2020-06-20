using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class editedInstallTechModelAndController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InstallTechs",
                table: "InstallTechs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f0dd1a0-0e87-4c62-8be1-229ea3e7e0af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b86246f-738d-46f1-9696-28b9ebcd2f48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a783ce05-d970-4fe1-8345-20b8e80fb621");

            migrationBuilder.DropColumn(
                name: "TechId",
                table: "InstallTechs");

            migrationBuilder.AddColumn<int>(
                name: "InstallTechId",
                table: "InstallTechs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstallTechs",
                table: "InstallTechs",
                column: "InstallTechId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_InstallTechs",
                table: "InstallTechs");

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
                name: "InstallTechId",
                table: "InstallTechs");

            migrationBuilder.AddColumn<int>(
                name: "TechId",
                table: "InstallTechs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstallTechs",
                table: "InstallTechs",
                column: "TechId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f0dd1a0-0e87-4c62-8be1-229ea3e7e0af", "e004f66a-ea69-4d9a-9748-7546ce8162be", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b86246f-738d-46f1-9696-28b9ebcd2f48", "bcf2dfbf-b35b-4daf-9011-f8b36ccbf440", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a783ce05-d970-4fe1-8345-20b8e80fb621", "9ef5e5ba-a6df-4aba-b230-0f8e81f7f979", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
