using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "055c71e3-7c58-4fa0-9aaa-2aa2e3b7e77c", 0, "1c96ff97-f7cf-4724-93ca-15724c7f645f", "guest@mail.com", false, "Guest", "User", false, null, "GUEST@MAIL.COM", "GUEST", "AQAAAAEAACcQAAAAELFpExEVayrkzn40+IwTR+BO3Nf0Kn22SPcHQJt1jaPo2aH4ltYBLo1tR7YNmRTH4Q==", null, false, "47fece48-991c-47bd-8e21-92b3e95412f9", false, "guest" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In Progress" },
                    { 3, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 15, 11, 44, 12, 433, DateTimeKind.Local).AddTicks(8655), "Learn using ASP.NET Core Identity", "055c71e3-7c58-4fa0-9aaa-2aa2e3b7e77c", "Prepare for ASP.NET Fundamentals exam" },
                    { 2, 3, new DateTime(2022, 5, 15, 11, 44, 12, 433, DateTimeKind.Local).AddTicks(8691), "Learn using EF Core and MS SQL Server Managment Studio", "055c71e3-7c58-4fa0-9aaa-2aa2e3b7e77c", "Improve EF Core skills" },
                    { 3, 2, new DateTime(2022, 10, 5, 11, 44, 12, 433, DateTimeKind.Local).AddTicks(8693), "Learn using ASP.NET Core Identity", "055c71e3-7c58-4fa0-9aaa-2aa2e3b7e77c", "Improve ASP.NET Core skills" },
                    { 4, 3, new DateTime(2021, 10, 15, 11, 44, 12, 433, DateTimeKind.Local).AddTicks(8696), "Prepare by solving old Mid and Final exams", "055c71e3-7c58-4fa0-9aaa-2aa2e3b7e77c", "Prepare for C# Fundamentals Exam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "055c71e3-7c58-4fa0-9aaa-2aa2e3b7e77c");

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boards",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
