using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LP03ClientSide.Migrations
{
    /// <inheritdoc />
    public partial class UserWork3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Works",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Works_UserId",
                table: "Works",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Users_UserId",
                table: "Works",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_Users_UserId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_UserId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Works");
        }
    }
}
