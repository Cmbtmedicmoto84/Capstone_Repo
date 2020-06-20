using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class fixedInstallTechesDboName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstallTechs_AspNetUsers_IdentityUserId",
                table: "InstallTechs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstallTechs",
                table: "InstallTechs");

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

            migrationBuilder.RenameTable(
                name: "InstallTechs",
                newName: "InstallTeches");

            migrationBuilder.RenameIndex(
                name: "IX_InstallTechs_IdentityUserId",
                table: "InstallTeches",
                newName: "IX_InstallTeches_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstallTeches",
                table: "InstallTeches",
                column: "InstallTechId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aba53c67-9a5f-426d-8fcb-9a78fde0dba9", "23821416-7b9c-4fdb-832e-608fc54bfb0d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c215eacd-d4ac-450d-a680-ccb753272d63", "432f1085-44bb-493a-b5a6-a1e960a56118", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ca5c933-8787-4b1b-b51c-3a359da90ae1", "1b7de1f3-6072-4dc1-97da-fa1faac26fd4", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.AddForeignKey(
                name: "FK_InstallTeches_AspNetUsers_IdentityUserId",
                table: "InstallTeches",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstallTeches_AspNetUsers_IdentityUserId",
                table: "InstallTeches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstallTeches",
                table: "InstallTeches");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ca5c933-8787-4b1b-b51c-3a359da90ae1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aba53c67-9a5f-426d-8fcb-9a78fde0dba9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c215eacd-d4ac-450d-a680-ccb753272d63");

            migrationBuilder.RenameTable(
                name: "InstallTeches",
                newName: "InstallTechs");

            migrationBuilder.RenameIndex(
                name: "IX_InstallTeches_IdentityUserId",
                table: "InstallTechs",
                newName: "IX_InstallTechs_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstallTechs",
                table: "InstallTechs",
                column: "InstallTechId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_InstallTechs_AspNetUsers_IdentityUserId",
                table: "InstallTechs",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
