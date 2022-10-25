using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Data.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserBook");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserBook_Books_BookId",
                table: "ApplicationUserBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserBook",
                table: "ApplicationUserBook");

            migrationBuilder.RenameTable(
                name: "ApplicationUserBook",
                newName: "ApplicationUsersBook");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserBook_BookId",
                table: "ApplicationUsersBook",
                newName: "IX_ApplicationUsersBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsersBook",
                table: "ApplicationUsersBook",
                columns: new[] { "ApplicationUserId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsersBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUsersBook",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsersBook_Books_BookId",
                table: "ApplicationUsersBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsersBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUsersBook");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsersBook_Books_BookId",
                table: "ApplicationUsersBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsersBook",
                table: "ApplicationUsersBook");

            migrationBuilder.RenameTable(
                name: "ApplicationUsersBook",
                newName: "ApplicationUserBook");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUsersBook_BookId",
                table: "ApplicationUserBook",
                newName: "IX_ApplicationUserBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserBook",
                table: "ApplicationUserBook",
                columns: new[] { "ApplicationUserId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBook_AspNetUsers_ApplicationUserId",
                table: "ApplicationUserBook",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserBook_Books_BookId",
                table: "ApplicationUserBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
