using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class TotalTimeAddedToTaskInstance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0f9237f1-a063-46cb-ac82-5faf1d7e82a7"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("182aed08-a652-4dc2-abf7-a1523b6007fc"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("27136272-0e28-4287-ba14-d5ecb4884076"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2c4cadc1-c0b4-4678-b730-9981074d709c"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("39289314-c4cd-4367-ad5e-119cde1a6d60"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("792b312b-7cb6-4cfa-abb9-c47c8f08730b"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("af0fffdc-bf6d-403f-8f40-c4f1d32d0501"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d9549304-1df0-4022-b7fe-152249000532"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e67571d2-a7ac-4ce2-93f3-5e12add0f75b"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f75ce5bb-9f05-4150-abf6-870d6eca6413"));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TotalTime",
                table: "TaskInstances",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskDefinitions",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "DefaultTimeSpan", "Title" },
                values: new object[,]
                {
                    { new Guid("3fcc981a-e897-4d60-9477-60a554cb743b"), 0L, "TaskDefinition 1" },
                    { new Guid("dc8bc4b9-a10e-4bbe-917c-9a0c7907b6f7"), 0L, "TaskDefinition 2" },
                    { new Guid("f44a024c-9533-4bd5-9e3f-45eee625e72e"), 0L, "TaskDefinition 3" },
                    { new Guid("887617e3-af07-4200-8910-f0c9b5b29f24"), 0L, "TaskDefinition 4" },
                    { new Guid("15153bcf-3d0e-4a9d-a5fa-03ab3eea871d"), 0L, "TaskDefinition 5" },
                    { new Guid("7286d37e-fb48-4163-a01a-783a05e5f241"), 0L, "TaskDefinition 6" },
                    { new Guid("fc372706-fa10-464b-b39a-f65038866eb5"), 0L, "TaskDefinition 7" },
                    { new Guid("6de3c3f0-7d58-4eb7-a83a-0c8f4bb5c361"), 0L, "TaskDefinition 8" },
                    { new Guid("49ef5a9d-385e-47ac-b7f8-1f9824fb6093"), 0L, "TaskDefinition 9" },
                    { new Guid("a4024854-1b36-460c-965f-8460a64fe500"), 0L, "TaskDefinition 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("15153bcf-3d0e-4a9d-a5fa-03ab3eea871d"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("3fcc981a-e897-4d60-9477-60a554cb743b"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("49ef5a9d-385e-47ac-b7f8-1f9824fb6093"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6de3c3f0-7d58-4eb7-a83a-0c8f4bb5c361"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7286d37e-fb48-4163-a01a-783a05e5f241"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("887617e3-af07-4200-8910-f0c9b5b29f24"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a4024854-1b36-460c-965f-8460a64fe500"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("dc8bc4b9-a10e-4bbe-917c-9a0c7907b6f7"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f44a024c-9533-4bd5-9e3f-45eee625e72e"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("fc372706-fa10-464b-b39a-f65038866eb5"));

            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "TaskInstances");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskDefinitions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "DefaultTimeSpan", "Title" },
                values: new object[,]
                {
                    { new Guid("0f9237f1-a063-46cb-ac82-5faf1d7e82a7"), 0L, "TaskDefinition 1" },
                    { new Guid("792b312b-7cb6-4cfa-abb9-c47c8f08730b"), 0L, "TaskDefinition 2" },
                    { new Guid("af0fffdc-bf6d-403f-8f40-c4f1d32d0501"), 0L, "TaskDefinition 3" },
                    { new Guid("f75ce5bb-9f05-4150-abf6-870d6eca6413"), 0L, "TaskDefinition 4" },
                    { new Guid("27136272-0e28-4287-ba14-d5ecb4884076"), 0L, "TaskDefinition 5" },
                    { new Guid("d9549304-1df0-4022-b7fe-152249000532"), 0L, "TaskDefinition 6" },
                    { new Guid("2c4cadc1-c0b4-4678-b730-9981074d709c"), 0L, "TaskDefinition 7" },
                    { new Guid("e67571d2-a7ac-4ce2-93f3-5e12add0f75b"), 0L, "TaskDefinition 8" },
                    { new Guid("39289314-c4cd-4367-ad5e-119cde1a6d60"), 0L, "TaskDefinition 9" },
                    { new Guid("182aed08-a652-4dc2-abf7-a1523b6007fc"), 0L, "TaskDefinition 10" }
                });
        }
    }
}
