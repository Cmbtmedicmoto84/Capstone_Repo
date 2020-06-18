using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class fixingDbErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpSupportTickets_Customers_CustomerAccountId",
                table: "HelpSupportTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceAppointments_Customers_CustomerAccountId",
                table: "ServiceAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInstallOrders_Customers_CustomerAccountId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d49559f-a98a-4592-baed-b08cbc854c5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776c2847-8615-4749-8067-fd137571fef5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2f0df8-908d-405c-9f0a-cdb3b5101b05");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "AccountNumber",
                table: "Customers",
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
                values: new object[] { "e9b7091a-e2db-4600-959c-744dc5dad031", "b16f2975-b43d-474c-b0dd-af16c99d8ce2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d0a3898-0bc1-438c-a85d-2733fc5f064c", "4efb3391-6bce-4cac-a12e-870a58f02a92", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56211f84-e3f9-41fc-a6d8-a3b45b9c73c1", "defec6ab-ce3e-498c-899b-080456e8e983", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.AddForeignKey(
                name: "FK_HelpSupportTickets_Customers_CustomerAccountId",
                table: "HelpSupportTickets",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "AccountNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceAppointments_Customers_CustomerAccountId",
                table: "ServiceAppointments",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "AccountNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInstallOrders_Customers_CustomerAccountId",
                table: "ServiceInstallOrders",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "AccountNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpSupportTickets_Customers_CustomerAccountId",
                table: "HelpSupportTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceAppointments_Customers_CustomerAccountId",
                table: "ServiceAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInstallOrders_Customers_CustomerAccountId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
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
                name: "AccountNumber",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d49559f-a98a-4592-baed-b08cbc854c5e", "e375696d-d0f3-47df-9112-64c9889caeae", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "776c2847-8615-4749-8067-fd137571fef5", "646c9568-768e-4029-be53-6eb7a532c52b", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd2f0df8-908d-405c-9f0a-cdb3b5101b05", "9e5dd3f0-e322-4679-8f28-b8c3a17b9b36", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.AddForeignKey(
                name: "FK_HelpSupportTickets_Customers_CustomerAccountId",
                table: "HelpSupportTickets",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceAppointments_Customers_CustomerAccountId",
                table: "ServiceAppointments",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInstallOrders_Customers_CustomerAccountId",
                table: "ServiceInstallOrders",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
