using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class fixingDberror : Migration
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
                keyValue: "85ec2dc9-fe64-420b-9793-dcae796f909f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd284b6-c773-44f0-9937-25869ff5ea8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c39b5b43-7c85-49d4-8b67-5f9a49d25ac9");

            migrationBuilder.DropColumn(
                name: "CustomerAccountId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Customers",
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
                name: "CustomerAccountId",
                table: "Customers",
                type: "int",
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
                values: new object[] { "c39b5b43-7c85-49d4-8b67-5f9a49d25ac9", "60a4e7be-7ef0-41f0-b06a-da88cac1de33", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85ec2dc9-fe64-420b-9793-dcae796f909f", "febe0dfe-7e36-4c23-9cba-f07bfce58900", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dd284b6-c773-44f0-9937-25869ff5ea8a", "25a04ab9-6cee-41d1-a54d-3781f206e649", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.AddForeignKey(
                name: "FK_HelpSupportTickets_Customers_CustomerAccountId",
                table: "HelpSupportTickets",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "CustomerAccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceAppointments_Customers_CustomerAccountId",
                table: "ServiceAppointments",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "CustomerAccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInstallOrders_Customers_CustomerAccountId",
                table: "ServiceInstallOrders",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "CustomerAccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
