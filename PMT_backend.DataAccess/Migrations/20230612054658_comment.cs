using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMT_backend.DataAccess.Migrations
{
    public partial class comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4207c07b-16d3-4f1f-a53f-f124f9eae282", "1", "Admin", "Admin" },
                    { "bbf42401-952f-4e25-8a65-0c761ba950fb", "3", "Initiative Lead", "Initiative Lead" },
                    { "cd86ed40-f297-4d5a-a7b6-1d8645e9e9fb", "2", "User", "User" },
                    { "f7046759-4b81-4190-acf8-93978d6de0ce", "5", "Supervisor", "Supervisor" },
                    { "fdf937b1-8075-4369-a8b2-c29c6002acfc", "4", "Initiative Evaluator", "Initiative Evaluator" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4207c07b-16d3-4f1f-a53f-f124f9eae282");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbf42401-952f-4e25-8a65-0c761ba950fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd86ed40-f297-4d5a-a7b6-1d8645e9e9fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7046759-4b81-4190-acf8-93978d6de0ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdf937b1-8075-4369-a8b2-c29c6002acfc");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Comments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
