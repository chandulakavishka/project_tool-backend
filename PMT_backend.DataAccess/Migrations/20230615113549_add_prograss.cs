using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMT_backend.DataAccess.Migrations
{
    public partial class add_prograss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Prograss",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1777004e-0c26-474f-bed3-f9a225ba0cb1", "1", "Admin", "Admin" },
                    { "c09b1665-6ce3-45ed-9f05-e0ba21d42cad", "4", "Initiative Evaluator", "Initiative Evaluator" },
                    { "c76734e2-df2f-44c2-a8e0-be7d03f8029d", "2", "User", "User" },
                    { "dafee7db-311c-4b9e-ae10-47d9753221a7", "3", "Initiative Lead", "Initiative Lead" },
                    { "e71fd551-c620-43ae-8f18-a9f1f828f794", "5", "Supervisor", "Supervisor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1777004e-0c26-474f-bed3-f9a225ba0cb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c09b1665-6ce3-45ed-9f05-e0ba21d42cad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c76734e2-df2f-44c2-a8e0-be7d03f8029d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dafee7db-311c-4b9e-ae10-47d9753221a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e71fd551-c620-43ae-8f18-a9f1f828f794");

            migrationBuilder.DropColumn(
                name: "Prograss",
                table: "Tasks");

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
    }
}
