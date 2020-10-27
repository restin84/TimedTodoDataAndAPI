using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class ChangedTaskDefinitionConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("404b9dd4-6872-4ab1-8d2f-4034c75fc055"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("542b7286-41b4-4e9c-9404-41186763d37e"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("88506f88-a7f5-4493-83ec-8a87f921d666"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a96a7984-ffd0-4654-8f89-0298db3903bd"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b16a23ee-76c8-4ebf-ac3f-f70c3a3e5573"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d0d52735-2d38-42ed-97bd-8a099c1b07a1"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e22b9297-5797-47f4-ba9e-61b392d86f09"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e5da4dc2-c1e9-4341-9756-9639767a3512"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f03fe60b-e441-46f3-90b0-d7f73891debf"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f0f44299-9c0f-4ba9-99fe-c10fc42e923d"));

            migrationBuilder.DropColumn(
                name: "DefaultTimeSpan",
                table: "TaskDefinitions");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "DefaultTimeSpan",
                table: "TaskDefinitions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
        }
    }
}
