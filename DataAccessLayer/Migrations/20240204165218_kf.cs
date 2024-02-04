using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class kf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_teles_users_UserID",
                table: "user_teles");

            migrationBuilder.DropIndex(
                name: "IX_user_teles_UserID",
                table: "user_teles");

            migrationBuilder.CreateTable(
                name: "UserUser_Tele",
                columns: table => new
                {
                    TelesId = table.Column<int>(type: "int", nullable: false),
                    usersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUser_Tele", x => new { x.TelesId, x.usersId });
                    table.ForeignKey(
                        name: "FK_UserUser_Tele_user_teles_TelesId",
                        column: x => x.TelesId,
                        principalTable: "user_teles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUser_Tele_users_usersId",
                        column: x => x.usersId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserUser_Tele_usersId",
                table: "UserUser_Tele",
                column: "usersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserUser_Tele");

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
    }
}
