using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class SeedInitialTaskDefinitions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("70cb13f8-a0ed-4e3f-b534-957c981d7dfb"), "First Task Definition" },
                    { new Guid("4e3741cf-7025-4192-8158-c38fc3d53fe5"), "Second Task Definition" },
                    { new Guid("ace0a6f2-f01c-4217-9ea0-5aa9912bf767"), "Third Task Definition" },
                    { new Guid("9f75d6a2-4820-476b-b9a4-a7332b899063"), "Forth Task Definition" },
                    { new Guid("d0e39ceb-2bfe-47c8-ad6d-eb24d79ff11f"), "Fifth Task Definition" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4e3741cf-7025-4192-8158-c38fc3d53fe5"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("70cb13f8-a0ed-4e3f-b534-957c981d7dfb"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9f75d6a2-4820-476b-b9a4-a7332b899063"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ace0a6f2-f01c-4217-9ea0-5aa9912bf767"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d0e39ceb-2bfe-47c8-ad6d-eb24d79ff11f"));
        }
    }
}
