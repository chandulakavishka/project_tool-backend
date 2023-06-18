using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMT_backend.DataAccess.Migrations
{
    public partial class add_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "396bf071-d40e-4687-8e5e-6c66ef5c4768");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "663e0e22-765b-4c50-be94-429e77e5f063");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cfc440f-6c23-4a1d-bce7-5dc7a1dbd598");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a22068d-ca6a-49d5-b3c5-cee5f66854f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc55af34-c4fd-4850-a45f-2596cbdd6750");

            migrationBuilder.CreateTable(
                name: "TaskUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InnovativeId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "324c033b-e484-4c90-8be9-8967567202f0", "3", "Initiative Lead", "Initiative Lead" },
                    { "327a3fa5-7c36-46b9-9004-e081e95e544e", "2", "User", "User" },
                    { "5cc9ea9c-9360-49f1-b6b9-f7750e58ff32", "1", "Admin", "Admin" },
                    { "e953e4fc-9d5d-4b3c-9c57-d795770acd64", "5", "Supervisor", "Supervisor" },
                    { "f62e6f1d-0618-4e1d-9195-ccaebd88e66d", "4", "Initiative Evaluator", "Initiative Evaluator" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskUser");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "324c033b-e484-4c90-8be9-8967567202f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "327a3fa5-7c36-46b9-9004-e081e95e544e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cc9ea9c-9360-49f1-b6b9-f7750e58ff32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e953e4fc-9d5d-4b3c-9c57-d795770acd64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f62e6f1d-0618-4e1d-9195-ccaebd88e66d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "396bf071-d40e-4687-8e5e-6c66ef5c4768", "4", "Initiative Evaluator", "Initiative Evaluator" },
                    { "663e0e22-765b-4c50-be94-429e77e5f063", "5", "Supervisor", "Supervisor" },
                    { "6cfc440f-6c23-4a1d-bce7-5dc7a1dbd598", "1", "Admin", "Admin" },
                    { "7a22068d-ca6a-49d5-b3c5-cee5f66854f7", "2", "User", "User" },
                    { "fc55af34-c4fd-4850-a45f-2596cbdd6750", "3", "Initiative Lead", "Initiative Lead" }
                });
        }
    }
}
