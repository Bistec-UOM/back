using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class v : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "user_teles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_user_teles_UserID",
                table: "user_teles",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_user_teles_users_UserID",
                table: "user_teles",
                column: "UserID",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_teles_users_UserID",
                table: "user_teles");

            migrationBuilder.DropIndex(
                name: "IX_user_teles_UserID",
                table: "user_teles");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "user_teles");
        }
    }
}
