using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMT_backend.DataAccess.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c7d8a54-d47c-4985-9824-6d763fb24cc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "887662a3-fa05-4f37-b178-59fbe5d9987f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4f3c581-6ec8-492c-a61b-736e47a81108");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c75f1ef3-7905-4380-8514-c6548cf352dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1a37704-cd07-432f-81c9-8d64e1b9679a");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InnovativeId = table.Column<int>(type: "int", nullable: false),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Tasks");

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
                    { "3c7d8a54-d47c-4985-9824-6d763fb24cc0", "2", "User", "User" },
                    { "887662a3-fa05-4f37-b178-59fbe5d9987f", "3", "Initiative Lead", "Initiative Lead" },
                    { "a4f3c581-6ec8-492c-a61b-736e47a81108", "4", "Initiative Evaluator", "Initiative Evaluator" },
                    { "c75f1ef3-7905-4380-8514-c6548cf352dc", "1", "Admin", "Admin" },
                    { "d1a37704-cd07-432f-81c9-8d64e1b9679a", "5", "Supervisor", "Supervisor" }
                });
        }
    }
}
