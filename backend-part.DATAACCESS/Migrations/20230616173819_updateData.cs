using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapp.DATAACCESS.Migrations
{
    /// <inheritdoc />
    public partial class updateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 16, 23, 8, 19, 203, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 16, 23, 8, 19, 203, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 16, 23, 8, 19, 203, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 4,
                column: "Role",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 5,
                column: "Role",
                value: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UId", "Email", "PhoneNo", "Role", "UserName" },
                values: new object[] { 6, "Jayawardhana@gmail.com", "", 3, "Jayawardhana" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 16, 23, 6, 12, 849, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 16, 23, 6, 12, 849, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Innovatives",
                keyColumn: "InnovativeId",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 16, 23, 6, 12, 849, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 4,
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UId",
                keyValue: 5,
                column: "Role",
                value: 1);
        }
    }
}
