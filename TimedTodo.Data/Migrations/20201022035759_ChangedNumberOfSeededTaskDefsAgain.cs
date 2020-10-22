using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class ChangedNumberOfSeededTaskDefsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("08ddb95f-bf7f-47ee-b681-d1afc1298f45"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1496ac91-19f9-40fd-8aa7-a310dd2eb368"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("191188e6-9975-4e0c-855d-6b55c3cdb9bf"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4c43fd58-8c96-45e9-92dd-c46d3c38aa04"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5ed07186-de28-4be1-ab94-348adb70d372"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("68cf8963-03cd-46a8-ab79-a9bdf192d665"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("708c0e54-063e-454d-83fd-5e942752a589"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7dffd094-3cd9-4923-9e5f-18fc8d0dc8ad"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("80fc10c4-e38e-4bc4-9a43-6ace502ad560"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ee3accc7-e1fd-41d0-a450-15ce2bbfef68"));

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "DefaultTimeSpan", "Title" },
                values: new object[,]
                {
                    { new Guid("c7c9f6d3-3d0e-4a3b-9918-ca3feb480f85"), 0L, "TaskDefinition 1" },
                    { new Guid("ebb95554-897d-4e0e-8cda-a2c8c84f36df"), 0L, "TaskDefinition 2" },
                    { new Guid("caef9a1f-860d-459f-ac12-838c3d713d39"), 0L, "TaskDefinition 3" },
                    { new Guid("73bed43c-6917-48be-bae7-77da35f8cac9"), 0L, "TaskDefinition 4" },
                    { new Guid("01851adb-dcc0-418d-8bd5-06214c512371"), 0L, "TaskDefinition 5" },
                    { new Guid("9aa1baa1-7377-425e-a9e7-89b08288bf15"), 0L, "TaskDefinition 6" },
                    { new Guid("48bd310a-8106-4df2-aff7-96d6f94c71e0"), 0L, "TaskDefinition 7" },
                    { new Guid("f9a510b7-25db-4b2a-a9ab-97513ff9a932"), 0L, "TaskDefinition 8" },
                    { new Guid("30bd93c2-f11d-4778-964f-3508a73da085"), 0L, "TaskDefinition 9" },
                    { new Guid("e7e9c770-7556-4f95-85a0-dd94a48b27e9"), 0L, "TaskDefinition 10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("01851adb-dcc0-418d-8bd5-06214c512371"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("30bd93c2-f11d-4778-964f-3508a73da085"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("48bd310a-8106-4df2-aff7-96d6f94c71e0"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("73bed43c-6917-48be-bae7-77da35f8cac9"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9aa1baa1-7377-425e-a9e7-89b08288bf15"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c7c9f6d3-3d0e-4a3b-9918-ca3feb480f85"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("caef9a1f-860d-459f-ac12-838c3d713d39"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e7e9c770-7556-4f95-85a0-dd94a48b27e9"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ebb95554-897d-4e0e-8cda-a2c8c84f36df"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f9a510b7-25db-4b2a-a9ab-97513ff9a932"));

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "DefaultTimeSpan", "Title" },
                values: new object[,]
                {
                    { new Guid("708c0e54-063e-454d-83fd-5e942752a589"), 0L, "TaskDefinition 1" },
                    { new Guid("191188e6-9975-4e0c-855d-6b55c3cdb9bf"), 0L, "TaskDefinition 2" },
                    { new Guid("5ed07186-de28-4be1-ab94-348adb70d372"), 0L, "TaskDefinition 3" },
                    { new Guid("80fc10c4-e38e-4bc4-9a43-6ace502ad560"), 0L, "TaskDefinition 4" },
                    { new Guid("08ddb95f-bf7f-47ee-b681-d1afc1298f45"), 0L, "TaskDefinition 5" },
                    { new Guid("7dffd094-3cd9-4923-9e5f-18fc8d0dc8ad"), 0L, "TaskDefinition 6" },
                    { new Guid("4c43fd58-8c96-45e9-92dd-c46d3c38aa04"), 0L, "TaskDefinition 7" },
                    { new Guid("ee3accc7-e1fd-41d0-a450-15ce2bbfef68"), 0L, "TaskDefinition 8" },
                    { new Guid("1496ac91-19f9-40fd-8aa7-a310dd2eb368"), 0L, "TaskDefinition 9" },
                    { new Guid("68cf8963-03cd-46a8-ab79-a9bdf192d665"), 0L, "TaskDefinition 10" }
                });
        }
    }
}
