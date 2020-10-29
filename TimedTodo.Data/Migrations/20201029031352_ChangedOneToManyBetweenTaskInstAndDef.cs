using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class ChangedOneToManyBetweenTaskInstAndDef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
