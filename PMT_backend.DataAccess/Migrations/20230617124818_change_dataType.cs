using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMT_backend.DataAccess.Migrations
{
    public partial class change_dataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "InnovativeId",
                table: "TaskUser");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TaskUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d2cf9fb-aae0-4be5-ab23-a97e606fdc84", "1", "Admin", "Admin" },
                    { "448ff313-4307-498a-ae81-66f2fc9710f3", "5", "Supervisor", "Supervisor" },
                    { "7d71f348-7094-44be-839c-8ef57421c4f6", "2", "User", "User" },
                    { "b4893380-9c78-49d3-a817-ffa914cb76e5", "4", "Initiative Evaluator", "Initiative Evaluator" },
                    { "d8d33cb9-6270-4f95-af05-ea4be34ecdd6", "3", "Initiative Lead", "Initiative Lead" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d2cf9fb-aae0-4be5-ab23-a97e606fdc84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "448ff313-4307-498a-ae81-66f2fc9710f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d71f348-7094-44be-839c-8ef57421c4f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4893380-9c78-49d3-a817-ffa914cb76e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8d33cb9-6270-4f95-af05-ea4be34ecdd6");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TaskUser");

            migrationBuilder.AddColumn<int>(
                name: "InnovativeId",
                table: "TaskUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
