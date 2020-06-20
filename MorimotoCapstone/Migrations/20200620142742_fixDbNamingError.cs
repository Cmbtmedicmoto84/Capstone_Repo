using Microsoft.EntityFrameworkCore.Migrations;

namespace MorimotoCapstone.Migrations
{
    public partial class fixDbNamingError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "e32e8743-744b-46e9-8075-2d5a58c780c9", "bf67571b-345c-4c33-94f0-224417bb06b8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c06aadd-5944-429b-9621-08a549305490", "c17b259d-3f41-454f-a061-41a4289d7790", "InstallTech", "INSTALLTECH" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b13dc5a5-5276-4923-b494-0790f5c848f4", "243005c5-9689-4c05-a733-486e2ec06484", "CustomerServiceRep", "CUSTOMERSERVICEREP" });

            migrationBuilder.AddForeignKey(
                name: "FK_InstallTechs_AspNetUsers_IdentityUserId",
                table: "InstallTechs",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "1c06aadd-5944-429b-9621-08a549305490");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13dc5a5-5276-4923-b494-0790f5c848f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e32e8743-744b-46e9-8075-2d5a58c780c9");

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
    }
}
