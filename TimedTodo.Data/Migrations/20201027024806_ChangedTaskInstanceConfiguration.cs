using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class ChangedTaskInstanceConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1d3bfb3b-0c37-4df5-91af-0c2180c0154d"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("416ab440-6e4a-4dc7-9e93-7d55a90fabcd"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("58ef63c3-c1b3-4401-b2e9-c7cf7f118f29"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5ccd9758-3bfc-4448-ba0a-8346b2be91cc"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7ea62ad2-ee80-487d-b643-f8f0807bbe47"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("87b45e51-abb0-41a9-8d2c-03d23c22ed45"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8854558d-5070-4feb-804b-465a9c30ebbd"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8e1b95f5-a28b-4b9c-9473-1c4157360d5e"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9c2d3e99-498b-4c19-8bb9-cff4b298b128"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bcd70b09-2439-49d8-80f7-c3204a08cc26"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("416ab440-6e4a-4dc7-9e93-7d55a90fabcd"), "TaskDefinition 1" },
                    { new Guid("bcd70b09-2439-49d8-80f7-c3204a08cc26"), "TaskDefinition 2" },
                    { new Guid("9c2d3e99-498b-4c19-8bb9-cff4b298b128"), "TaskDefinition 3" },
                    { new Guid("7ea62ad2-ee80-487d-b643-f8f0807bbe47"), "TaskDefinition 4" },
                    { new Guid("87b45e51-abb0-41a9-8d2c-03d23c22ed45"), "TaskDefinition 5" },
                    { new Guid("5ccd9758-3bfc-4448-ba0a-8346b2be91cc"), "TaskDefinition 6" },
                    { new Guid("58ef63c3-c1b3-4401-b2e9-c7cf7f118f29"), "TaskDefinition 7" },
                    { new Guid("1d3bfb3b-0c37-4df5-91af-0c2180c0154d"), "TaskDefinition 8" },
                    { new Guid("8854558d-5070-4feb-804b-465a9c30ebbd"), "TaskDefinition 9" },
                    { new Guid("8e1b95f5-a28b-4b9c-9473-1c4157360d5e"), "TaskDefinition 10" }
                });
        }
    }
}
