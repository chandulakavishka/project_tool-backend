using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.DATAACCESS.Migrations
{
    /// <inheritdoc />
    public partial class Addnewcolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 18, 13, 3, 51, 475, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 18, 13, 3, 51, 475, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 18, 13, 3, 51, 475, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 1,
                column: "FirstName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 2,
                column: "FirstName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 3,
                column: "FirstName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 4,
                column: "FirstName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 5,
                column: "FirstName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 6,
                column: "FirstName",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "UserName");

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 18, 12, 56, 37, 922, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 18, 12, 56, 37, 922, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 18, 12, 56, 37, 922, DateTimeKind.Local).AddTicks(5168));
        }
    }
}
