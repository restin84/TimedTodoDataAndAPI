using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class ForeignKeyToTaskInstance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskInstances_TaskDefinitions_TaskDefinitionId",
                table: "TaskInstances");

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("213a9b0c-eace-4118-b16b-7890bc3de82c"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5b3c83c3-79dd-442e-a27e-1b8651a601d9"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7733ab57-ead3-4bad-99b8-e1a00fb44afa"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("874e2796-bb10-49bc-80a3-2b8a4508df2f"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9a33fc01-97fe-4f26-a7be-34c6a34a057b"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("aa3c9f0b-6154-4f59-a758-a03ae16708fd"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b0600f6a-7f45-4520-81ec-03e05e03f35a"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b4b920d9-8be2-4db5-8992-ffef3ac2fbcb"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bd14b320-0773-4ccc-80fd-10cdacbe2442"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("da8a0c18-718d-40e0-936a-ee3f09deb47c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "TaskDefinitionId",
                table: "TaskInstances",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "DefaultTimeSpan", "Title" },
                values: new object[,]
                {
                    { new Guid("c563fcb5-d15f-4a1d-853f-269c80ae102c"), 0L, "TaskDefinition 1" },
                    { new Guid("9d9c89cb-8a3a-42f1-b88d-bd6230acb1b4"), 0L, "TaskDefinition 2" },
                    { new Guid("8df6cb74-382a-4578-8836-0a0048a2fec5"), 0L, "TaskDefinition 3" },
                    { new Guid("f215df93-3c32-4e1c-8a56-ad5fa98b7a40"), 0L, "TaskDefinition 4" },
                    { new Guid("057c8b15-2028-4abe-b3e1-b01d32a1f978"), 0L, "TaskDefinition 5" },
                    { new Guid("db9a4019-7bc5-4c1a-8aa2-0e055732a3cd"), 0L, "TaskDefinition 6" },
                    { new Guid("126dea40-fe2c-4604-8d3b-a57b58294b26"), 0L, "TaskDefinition 7" },
                    { new Guid("4d9416f7-8f21-4739-9ce5-13a8f0e3ca2b"), 0L, "TaskDefinition 8" },
                    { new Guid("d2e0f165-990e-48af-ae4f-255d624f8309"), 0L, "TaskDefinition 9" },
                    { new Guid("4eefbef3-53cb-4027-8b41-4c6af1567983"), 0L, "TaskDefinition 10" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskInstances_TaskDefinitions_TaskDefinitionId",
                table: "TaskInstances",
                column: "TaskDefinitionId",
                principalTable: "TaskDefinitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskInstances_TaskDefinitions_TaskDefinitionId",
                table: "TaskInstances");

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("057c8b15-2028-4abe-b3e1-b01d32a1f978"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("126dea40-fe2c-4604-8d3b-a57b58294b26"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4d9416f7-8f21-4739-9ce5-13a8f0e3ca2b"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4eefbef3-53cb-4027-8b41-4c6af1567983"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8df6cb74-382a-4578-8836-0a0048a2fec5"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9d9c89cb-8a3a-42f1-b88d-bd6230acb1b4"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c563fcb5-d15f-4a1d-853f-269c80ae102c"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d2e0f165-990e-48af-ae4f-255d624f8309"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("db9a4019-7bc5-4c1a-8aa2-0e055732a3cd"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f215df93-3c32-4e1c-8a56-ad5fa98b7a40"));

            migrationBuilder.AlterColumn<Guid>(
                name: "TaskDefinitionId",
                table: "TaskInstances",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "DefaultTimeSpan", "Title" },
                values: new object[,]
                {
                    { new Guid("5b3c83c3-79dd-442e-a27e-1b8651a601d9"), 0L, "TaskDefinition 1" },
                    { new Guid("aa3c9f0b-6154-4f59-a758-a03ae16708fd"), 0L, "TaskDefinition 2" },
                    { new Guid("da8a0c18-718d-40e0-936a-ee3f09deb47c"), 0L, "TaskDefinition 3" },
                    { new Guid("b4b920d9-8be2-4db5-8992-ffef3ac2fbcb"), 0L, "TaskDefinition 4" },
                    { new Guid("b0600f6a-7f45-4520-81ec-03e05e03f35a"), 0L, "TaskDefinition 5" },
                    { new Guid("9a33fc01-97fe-4f26-a7be-34c6a34a057b"), 0L, "TaskDefinition 6" },
                    { new Guid("874e2796-bb10-49bc-80a3-2b8a4508df2f"), 0L, "TaskDefinition 7" },
                    { new Guid("7733ab57-ead3-4bad-99b8-e1a00fb44afa"), 0L, "TaskDefinition 8" },
                    { new Guid("bd14b320-0773-4ccc-80fd-10cdacbe2442"), 0L, "TaskDefinition 9" },
                    { new Guid("213a9b0c-eace-4118-b16b-7890bc3de82c"), 0L, "TaskDefinition 10" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskInstances_TaskDefinitions_TaskDefinitionId",
                table: "TaskInstances",
                column: "TaskDefinitionId",
                principalTable: "TaskDefinitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
