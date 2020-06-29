using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class UpdatedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "196817c3-a47d-4e7b-9936-3c95b129d439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f9d91ce-fa07-4579-9ad9-7265c4f20f0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4bddf95-4e28-4f7d-83b0-644209a32a4f");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Timezone",
                table: "Appointments");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDate",
                table: "Appointments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentTime",
                table: "Appointments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CustomerAccountId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceInstallOrderOrderId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceOrderDetailOrderDetailId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: false),
                    CartTotal = table.Column<double>(nullable: false),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ecab5f4-9fe8-44de-834c-ed00f141b181", "9506e806-b1e9-4b1f-b2e8-85e3ce5f8d1f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4633f02c-b2fe-40e5-a7ad-e825d57da9d5", "e83a5edf-0a4e-4ec3-8c63-fb888ffccde2", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "806c23e8-fbd2-4c67-9bad-670797acf4a4", "7870cde2-61c2-49ce-a203-ad5007be925d", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerAccountId",
                table: "Appointments",
                column: "CustomerAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceInstallOrderOrderId",
                table: "Appointments",
                column: "ServiceInstallOrderOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceOrderDetailOrderDetailId",
                table: "Appointments",
                column: "ServiceOrderDetailOrderDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_CustomerAccountId",
                table: "Appointments",
                column: "CustomerAccountId",
                principalTable: "Customers",
                principalColumn: "CustomerAccountId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_ServiceInstallOrders_ServiceInstallOrderOrderId",
                table: "Appointments",
                column: "ServiceInstallOrderOrderId",
                principalTable: "ServiceInstallOrders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_ServiceOrderDetails_ServiceOrderDetailOrderDetailId",
                table: "Appointments",
                column: "ServiceOrderDetailOrderDetailId",
                principalTable: "ServiceOrderDetails",
                principalColumn: "OrderDetailId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_CustomerAccountId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_ServiceInstallOrders_ServiceInstallOrderOrderId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_ServiceOrderDetails_ServiceOrderDetailOrderDetailId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_CustomerAccountId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceInstallOrderOrderId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceOrderDetailOrderDetailId",
                table: "Appointments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ecab5f4-9fe8-44de-834c-ed00f141b181");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4633f02c-b2fe-40e5-a7ad-e825d57da9d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "806c23e8-fbd2-4c67-9bad-670797acf4a4");

            migrationBuilder.DropColumn(
                name: "AppointmentDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CustomerAccountId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "OrderDetailId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ServiceInstallOrderOrderId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ServiceOrderDetailOrderDetailId",
                table: "Appointments");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Timezone",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f9d91ce-fa07-4579-9ad9-7265c4f20f0c", "54959f29-2629-4599-8d9c-9388d06c73a3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "196817c3-a47d-4e7b-9936-3c95b129d439", "933c90ce-4ba4-4601-b777-ad7908c5dfe4", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4bddf95-4e28-4f7d-83b0-644209a32a4f", "b9d82be6-c5ce-430e-836e-1934d8cffe7c", "CustomerServiceRep", "CUSTOMERSERVICEREP" });
        }
    }
}
