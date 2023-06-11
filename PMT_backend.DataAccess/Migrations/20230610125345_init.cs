using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMT_backend.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c280881-07ce-400d-83ab-955a1961efa5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52df7c96-6322-4734-848d-f240748c32c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b207f31-0c56-435f-b616-8b666380e410");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8d411c5-b447-4a48-9f57-f012191642c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e572a6ac-a35a-4a61-9c6d-9e81c854fd57");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09cb4422-e517-40f4-b7ab-266e00712314", "4", "Initiative Evaluator", "Initiative Evaluator" },
                    { "1a5233bf-1785-49d6-b776-358c799dcbc9", "1", "Admin", "Admin" },
                    { "cdc1b018-9ff3-42c1-94f5-f4f1993827b8", "3", "Initiative Lead", "Initiative Lead" },
                    { "d95250f9-e764-4227-814a-4ba10d9a9618", "2", "User", "User" },
                    { "e4a99d7e-73b0-42d6-8e9e-2bd8e48caaa9", "5", "Supervisor", "Supervisor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09cb4422-e517-40f4-b7ab-266e00712314");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a5233bf-1785-49d6-b776-358c799dcbc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdc1b018-9ff3-42c1-94f5-f4f1993827b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d95250f9-e764-4227-814a-4ba10d9a9618");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4a99d7e-73b0-42d6-8e9e-2bd8e48caaa9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c280881-07ce-400d-83ab-955a1961efa5", "4", "Initiative Evaluator", "Initiative Evaluator" },
                    { "52df7c96-6322-4734-848d-f240748c32c7", "2", "User", "User" },
                    { "5b207f31-0c56-435f-b616-8b666380e410", "1", "Admin", "Admin" },
                    { "d8d411c5-b447-4a48-9f57-f012191642c8", "3", "Initiative Lead", "Initiative Lead" },
                    { "e572a6ac-a35a-4a61-9c6d-9e81c854fd57", "5", "Supervisor", "Supervisor" }
                });
        }
    }
}
