using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LP03ClientSide.Migrations
{
    /// <inheritdoc />
    public partial class UserWork2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Works",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Works",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Works");
        }
    }
}
