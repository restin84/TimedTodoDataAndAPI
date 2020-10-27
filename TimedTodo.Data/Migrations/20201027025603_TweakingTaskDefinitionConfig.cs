using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class TweakingTaskDefinitionConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("089ae43d-2f2a-4bd8-8b6b-37c1e0b98685"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("18e36009-a1cf-4d2b-9094-fc605a99f212"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5a31a753-ff59-46b7-af1f-33eabddde031"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("783c476a-c01e-4b99-9836-a19bb1601b39"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a0e3ce30-535c-40c9-87f2-d12e16e0a1ce"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a9b66aba-9170-4379-9172-1f0b9233c3a6"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b2e148ac-6ead-4efe-babe-c6dd7380e1db"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bd6eaaff-a9f6-4fb8-9fd5-b8594f4fbef1"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bdcbcf75-0b13-42b7-85dd-4e01c5fa4091"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d60a20a0-76fc-4f64-9f08-b194e8a6ffdb"));

            migrationBuilder.AddColumn<long>(
                name: "DefaultTimeSpan",
                table: "TaskDefinitions",
                nullable: false,
                defaultValue: 0L);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "DefaultTimeSpan",
                table: "TaskDefinitions");

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("d60a20a0-76fc-4f64-9f08-b194e8a6ffdb"), "TaskDefinition 1" },
                    { new Guid("a9b66aba-9170-4379-9172-1f0b9233c3a6"), "TaskDefinition 2" },
                    { new Guid("bd6eaaff-a9f6-4fb8-9fd5-b8594f4fbef1"), "TaskDefinition 3" },
                    { new Guid("18e36009-a1cf-4d2b-9094-fc605a99f212"), "TaskDefinition 4" },
                    { new Guid("bdcbcf75-0b13-42b7-85dd-4e01c5fa4091"), "TaskDefinition 5" },
                    { new Guid("5a31a753-ff59-46b7-af1f-33eabddde031"), "TaskDefinition 6" },
                    { new Guid("089ae43d-2f2a-4bd8-8b6b-37c1e0b98685"), "TaskDefinition 7" },
                    { new Guid("783c476a-c01e-4b99-9836-a19bb1601b39"), "TaskDefinition 8" },
                    { new Guid("a0e3ce30-535c-40c9-87f2-d12e16e0a1ce"), "TaskDefinition 9" },
                    { new Guid("b2e148ac-6ead-4efe-babe-c6dd7380e1db"), "TaskDefinition 10" }
                });
        }
    }
}
