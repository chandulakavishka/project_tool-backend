using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace webapp.DATAACCESS.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Innovatives",
                columns: table => new
                {
                    InnovativeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InnovativeName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    LeadId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EvaluatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Innovatives", x => x.InnovativeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CurrentProgress = table.Column<int>(type: "int", nullable: true),
                    InnovativeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Tasks_Innovatives_InnovativeId",
                        column: x => x.InnovativeId,
                        principalTable: "Innovatives",
                        principalColumn: "InnovativeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Innovatives",
                columns: new[] { "InnovativeId", "Description", "EvaluatorId", "InnovativeName", "LeadId", "StartDate" },
                values: new object[,]
                {
                    { 1, "ABCD", "Kasun", "A", "Saman", new DateTime(2023, 6, 7, 18, 11, 23, 455, DateTimeKind.Local).AddTicks(9471) },
                    { 2, "PQRS", "Supun", "B", "Nimal", new DateTime(2023, 6, 7, 18, 11, 23, 455, DateTimeKind.Local).AddTicks(9491) },
                    { 3, "XYZ", "Saranga", "C", "Amal", new DateTime(2023, 6, 7, 18, 11, 23, 455, DateTimeKind.Local).AddTicks(9495) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UId", "Email", "PhoneNo", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "Chiransooriya1@gmail.com", "", 0, "Test1-DB" },
                    { 2, "Chiransooriya12@gmail.com", "", 2, "Test2" },
                    { 3, "Chiransooriya123@gmail.com", "", 1, "Test3" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "CurrentProgress", "Description", "InnovativeId", "TaskName" },
                values: new object[,]
                {
                    { 1, 0, "Description1", 1, "Finalize speaker and topic for the podcast" },
                    { 2, 1, "Description3", 2, "Test recording session" },
                    { 3, 2, "Description3", 3, "Task3" },
                    { 4, 0, "Description4", 1, "Finalize speaker and topic with speaker" },
                    { 5, 2, "Description5", 2, "Task5" },
                    { 6, 1, "Description6", 3, "Final recording session" },
                    { 7, 0, "Description7", 1, "Azure general best practices" },
                    { 8, 0, "Description8", 2, "Create new voiceCut" },
                    { 9, 0, "Description9", 3, "check previous database" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_InnovativeId",
                table: "Tasks",
                column: "InnovativeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Innovatives");
        }
    }
}
