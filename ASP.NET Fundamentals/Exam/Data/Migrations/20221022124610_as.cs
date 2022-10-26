using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsersBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUsersBook");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsersBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUsersBook",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsersBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUsersBook");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsersBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUsersBook",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
