using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMT_backend.DataAccess.Migrations
{
    public partial class add_duedate_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "DueDate",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
