using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_part.DataAccess.Migrations
{
    public partial class Addingnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InnovativeId",
                table: "MeetingNotes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "MeetingNotes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "MeetingNotes");

            migrationBuilder.AlterColumn<string>(
                name: "InnovativeId",
                table: "MeetingNotes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
