using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskDefinitions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    DefaultTimeSpan = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDefinitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskInstances",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ElapsedTime = table.Column<long>(nullable: false),
                    TaskDefinitionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskInstances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskInstances_TaskDefinitions_TaskDefinitionId",
                        column: x => x.TaskDefinitionId,
                        principalTable: "TaskDefinitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "DefaultTimeSpan", "Title" },
                values: new object[,]
                {
                    { new Guid("a96a7984-ffd0-4654-8f89-0298db3903bd"), 0L, "TaskDefinition 1" },
                    { new Guid("e5da4dc2-c1e9-4341-9756-9639767a3512"), 0L, "TaskDefinition 2" },
                    { new Guid("d0d52735-2d38-42ed-97bd-8a099c1b07a1"), 0L, "TaskDefinition 3" },
                    { new Guid("b16a23ee-76c8-4ebf-ac3f-f70c3a3e5573"), 0L, "TaskDefinition 4" },
                    { new Guid("e22b9297-5797-47f4-ba9e-61b392d86f09"), 0L, "TaskDefinition 5" },
                    { new Guid("542b7286-41b4-4e9c-9404-41186763d37e"), 0L, "TaskDefinition 6" },
                    { new Guid("f0f44299-9c0f-4ba9-99fe-c10fc42e923d"), 0L, "TaskDefinition 7" },
                    { new Guid("88506f88-a7f5-4493-83ec-8a87f921d666"), 0L, "TaskDefinition 8" },
                    { new Guid("f03fe60b-e441-46f3-90b0-d7f73891debf"), 0L, "TaskDefinition 9" },
                    { new Guid("404b9dd4-6872-4ab1-8d2f-4034c75fc055"), 0L, "TaskDefinition 10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskInstances_TaskDefinitionId",
                table: "TaskInstances",
                column: "TaskDefinitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskInstances");

            migrationBuilder.DropTable(
                name: "TaskDefinitions");
        }
    }
}
