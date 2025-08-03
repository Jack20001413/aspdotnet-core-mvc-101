using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableDiaryEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DairyEntries",
                table: "DairyEntries");

            migrationBuilder.RenameTable(
                name: "DairyEntries",
                newName: "DiaryEntries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiaryEntries",
                table: "DiaryEntries",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DiaryEntries",
                table: "DiaryEntries");

            migrationBuilder.RenameTable(
                name: "DiaryEntries",
                newName: "DairyEntries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DairyEntries",
                table: "DairyEntries",
                column: "Id");
        }
    }
}
