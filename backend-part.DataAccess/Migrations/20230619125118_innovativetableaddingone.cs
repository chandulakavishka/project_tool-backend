using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_part.DataAccess.Migrations
{
    public partial class innovativetableaddingone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InnovativeId",
                table: "SharePoints",
                newName: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "SharePoints",
                newName: "InnovativeId");
        }
    }
}
