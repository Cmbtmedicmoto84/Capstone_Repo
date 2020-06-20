using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class commentedOutControllersForUnseededObjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HelpSupportTickets_Customers_CustomerAccountId",
                table: "HelpSupportTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_HelpSupportTickets_Products_ProductId",
                table: "HelpSupportTickets");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceAppointments_Customers_CustomerAccountId",
                table: "ServiceAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInstallOrders_Customers_CustomerAccountId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInstallOrders_Products_ProductId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceInstallOrders_InstallTechs_TechId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropIndex(
                name: "IX_ServiceInstallOrders_CustomerAccountId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropIndex(
                name: "IX_ServiceInstallOrders_ProductId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropIndex(
                name: "IX_ServiceInstallOrders_TechId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropIndex(
                name: "IX_ServiceAppointments_CustomerAccountId",
                table: "ServiceAppointments");

            migrationBuilder.DropIndex(
                name: "IX_HelpSupportTickets_CustomerAccountId",
                table: "HelpSupportTickets");

            migrationBuilder.DropIndex(
                name: "IX_HelpSupportTickets_ProductId",
                table: "HelpSupportTickets");

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

            migrationBuilder.DropColumn(
                name: "CustomerAccountId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropColumn(
                name: "TechId",
                table: "ServiceInstallOrders");

            migrationBuilder.DropColumn(
                name: "CustomerAccountId",
                table: "ServiceAppointments");

            migrationBuilder.DropColumn(
                name: "CustomerAccountId",
                table: "HelpSupportTickets");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "HelpSupportTickets");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountId",
                table: "ServiceInstallOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ServiceInstallOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TechId",
                table: "ServiceInstallOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountId",
                table: "ServiceAppointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountId",
                table: "HelpSupportTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "HelpSupportTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6972fcb2-0a6e-4e25-b7c0-8360392be8ae", "bbc0e782-85e4-4cba-bcdb-47f182e68be0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f78d3d26-7cfd-448c-9c9f-a771d751ec88", "925407c1-1dd0-481f-a0f0-42cd73a95ff9", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "867d9e54-34b5-4c83-a3bc-d0d00e970e29", "c106dc83-9131-41ad-b326-f7467bdb2bdb", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInstallOrders_CustomerAccountId",
                table: "ServiceInstallOrders",
                column: "CustomerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInstallOrders_ProductId",
                table: "ServiceInstallOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInstallOrders_TechId",
                table: "ServiceInstallOrders",
                column: "TechId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAppointments_CustomerAccountId",
                table: "ServiceAppointments",
                column: "CustomerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpSupportTickets_CustomerAccountId",
                table: "HelpSupportTickets",
                column: "CustomerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_HelpSupportTickets_ProductId",
                table: "HelpSupportTickets",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_HelpSupportTickets_Customers_CustomerAccountId",
                table: "HelpSupportTickets",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "AccountNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HelpSupportTickets_Products_ProductId",
                table: "HelpSupportTickets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInstallOrders_Products_ProductId",
                table: "ServiceInstallOrders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceInstallOrders_InstallTechs_TechId",
                table: "ServiceInstallOrders",
                column: "TechId",
                principalTable: "InstallTechs",
                principalColumn: "TechId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
