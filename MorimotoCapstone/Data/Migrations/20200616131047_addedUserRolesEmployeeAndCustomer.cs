using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Data.Migrations
{
    public partial class addedUserRolesEmployeeAndCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39dad8e1-f82c-4e21-9e2b-3325d08487dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a13293c6-1287-48c9-aa02-e42fa34fe8ff");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerAccountId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeClassId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8e62b9c-fdd1-4731-a540-29a0603f133b", "39a18a1f-ea2d-4ca0-9c10-fc29f0d3ecc6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5dcace29-6674-4a29-8563-ebff40964b82", "c59fa65b-410b-4b53-a833-b2b92c0329d0", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dcace29-6674-4a29-8563-ebff40964b82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8e62b9c-fdd1-4731-a540-29a0603f133b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a13293c6-1287-48c9-aa02-e42fa34fe8ff", "8ad3f0fa-f904-4ee0-84e8-230e04ae729c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "39dad8e1-f82c-4e21-9e2b-3325d08487dd", "e42067f6-e6fd-4bd4-a060-6d7fbc733e59", "Employee", "EMPLOYEE" });
        }
    }
}
