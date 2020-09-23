using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TimedTodo.Data.Migrations
{
  public partial class init : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "TaskDefinitions",
          columns: table => new
          {
            Id = table.Column<Guid>(nullable: false),
            Title = table.Column<string>(nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_TaskDefinitions", x => x.Id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "TaskDefinitions");
    }
  }
}
