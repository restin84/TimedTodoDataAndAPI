﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimedTodo.Data.Migrations
{
    public partial class SeedAdditionalTaskDefinitions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "TaskDefinitions",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("251df60b-7c5d-4d38-87e3-55b3c07513d0"), "First Task Definition" },
                    { new Guid("55fc4433-0a3a-4a99-bb9d-70bed1468265"), "Third Task Definition" },
                    { new Guid("e08d159d-a9b0-4949-afe1-d13548f3c072"), "Second Task Definition" },
                    { new Guid("34033c66-857f-4c46-9675-7c3b9e9e850e"), "First Task Definition" },
                    { new Guid("f674d106-e9e9-437b-8f71-4879113eefaf"), "Fifth Task Definition" },
                    { new Guid("318f6e70-9f42-4751-a32c-41f6d61988f4"), "Forth Task Definition" },
                    { new Guid("86df2e57-b9d1-48f6-adf1-6f9888670fe7"), "Third Task Definition" },
                    { new Guid("27f84c93-e406-40c0-a028-e3ea8700e6cb"), "Second Task Definition" },
                    { new Guid("541f6662-1433-41a0-af79-971c9d4da00b"), "Forth Task Definition" },
                    { new Guid("c567dfb0-ca64-4344-bed7-3a0e2aa864c2"), "First Task Definition" },
                    { new Guid("b7114429-84d5-4ab8-86dd-fbe41715babb"), "Forth Task Definition" },
                    { new Guid("2da7c86b-7580-4b42-b270-2365f1b44579"), "Third Task Definition" },
                    { new Guid("e0fd8527-58b4-48ce-82e6-f4db2bc8be19"), "Second Task Definition" },
                    { new Guid("c23bd24b-8f61-4d64-89ad-776a92eec02e"), "First Task Definition" },
                    { new Guid("81c92073-3a6b-4278-820f-f51d3e3cc617"), "Fifth Task Definition" },
                    { new Guid("ce6bd23b-6256-4f33-9b73-7bd3e3494bbb"), "Forth Task Definition" },
                    { new Guid("685e0232-8b99-4af3-88de-bf7be53ac486"), "Third Task Definition" },
                    { new Guid("9d689985-f69a-4287-8707-8d2f3c15ef07"), "Fifth Task Definition" },
                    { new Guid("bfffc0f9-2564-4a80-89c8-af06bbdc3f5a"), "Second Task Definition" },
                    { new Guid("ddbc7fc6-2c88-4906-9c62-4b1c668d3d1f"), "Fifth Task Definition" },
                    { new Guid("429474ae-0bcd-4146-a635-a34f7da7889a"), "Second Task Definition" },
                    { new Guid("ee045199-1eb7-43dc-8edf-87d1d4c07980"), "Third Task Definition" },
                    { new Guid("938fd961-9a83-423f-893e-526b63631ffd"), "Second Task Definition" },
                    { new Guid("56276848-c6be-4f73-8aa4-6015f6ceadf2"), "First Task Definition" },
                    { new Guid("9cdab491-9d2b-4e85-8704-50d34df82b06"), "Fifth Task Definition" },
                    { new Guid("32452074-3b67-4355-91b3-ecfd712f855a"), "Forth Task Definition" },
                    { new Guid("7406edf3-6892-4814-932e-42af1adb3ba1"), "Third Task Definition" },
                    { new Guid("2e6ded76-70d7-48c1-a5a6-0bef84faf7d9"), "Second Task Definition" },
                    { new Guid("8a69482d-1be7-4f62-a518-dc908a76e8f7"), "First Task Definition" },
                    { new Guid("a9057e15-893a-4447-bd93-2139b89f85e0"), "First Task Definition" },
                    { new Guid("954b3c0a-388c-432a-bb2e-065be0c913f3"), "Forth Task Definition" },
                    { new Guid("aff9a989-e345-4e19-8c2a-9436e28f3203"), "Third Task Definition" },
                    { new Guid("872bc1f9-8d64-429c-baa7-371809200196"), "Second Task Definition" },
                    { new Guid("87790918-868c-4eec-8658-67f69c23ccae"), "First Task Definition" },
                    { new Guid("888e4f34-7642-4198-a4df-fa6061c97b85"), "Fifth Task Definition" },
                    { new Guid("e59db898-132e-4346-97ac-6a7b0c77d968"), "Forth Task Definition" },
                    { new Guid("50e0d147-2eb4-4e59-ac03-438a59634b2c"), "Third Task Definition" },
                    { new Guid("dd7fe925-3b69-4841-9dc7-9e3dd8836280"), "Fifth Task Definition" },
                    { new Guid("009d9721-f000-48e2-bfc6-3f47cda7db09"), "First Task Definition" },
                    { new Guid("15a8f876-4660-473f-954a-4487486d994a"), "Fifth Task Definition" },
                    { new Guid("cfae5f6d-fb2f-4a88-b168-d723dd280bf6"), "Forth Task Definition" },
                    { new Guid("f7ce4cdf-c1ab-4704-83e4-e345007dd44a"), "Second Task Definition" },
                    { new Guid("5550c4e4-bdfb-4487-9b07-c56e12f7aa59"), "First Task Definition" },
                    { new Guid("aaa18f55-9023-4b15-a947-24d8f6188920"), "Fifth Task Definition" },
                    { new Guid("fe8ed150-c34f-4e80-b135-f2551ddadc7e"), "Forth Task Definition" },
                    { new Guid("03075a0c-d8dc-4748-ae19-f58c7b867ebc"), "Third Task Definition" },
                    { new Guid("7f76a3b0-1c5b-4d37-a92a-af99fa9eb6d8"), "Second Task Definition" },
                    { new Guid("158c4f6f-8f3e-42e8-8d48-c665eecbf7bc"), "First Task Definition" },
                    { new Guid("e413eda5-892d-4558-bad0-577a82f6a875"), "Third Task Definition" },
                    { new Guid("a81df56c-444d-46b6-8056-f4ad86d22a12"), "Fifth Task Definition" },
                    { new Guid("1bf58f00-bfa2-4b36-b47b-c67a49e9279f"), "Third Task Definition" },
                    { new Guid("7dffd22b-9ea6-42d3-bc8f-8b029c996a4f"), "Second Task Definition" },
                    { new Guid("2f007dc3-77b3-441a-ad08-a25ffdd15adf"), "First Task Definition" },
                    { new Guid("bf7f07ee-b4aa-4a3c-9522-e04de38bd15f"), "Fifth Task Definition" },
                    { new Guid("1a1ed31a-a7a3-4241-aede-4cf11660e419"), "Forth Task Definition" },
                    { new Guid("0f0eac9a-2e45-4b16-9770-1b7d5c0cc54e"), "Third Task Definition" },
                    { new Guid("fd95bb28-7acb-417b-a592-0f51a79d347a"), "Second Task Definition" },
                    { new Guid("90cc32a7-1d57-4a1a-b514-c5b015f6afb9"), "Forth Task Definition" },
                    { new Guid("c5ae59a2-88a7-4703-b8a5-d8417392b47e"), "Forth Task Definition" },
                    { new Guid("d68f48d0-7cd3-4788-8b08-cdadb2d65a62"), "Fifth Task Definition" },
                    { new Guid("c807c14e-21c7-474e-891d-da4e4bea5dcc"), "First Task Definition" },
                    { new Guid("a3131ce0-d438-4797-b5eb-04c89d457221"), "Third Task Definition" },
                    { new Guid("da74fafd-11e2-4998-b789-3bea3ae2dc3f"), "Second Task Definition" },
                    { new Guid("092f31f1-f3b9-4520-810f-fa84d4d8a669"), "First Task Definition" },
                    { new Guid("94b1eb11-4d82-4bf0-a6fb-3e427ced9263"), "Fifth Task Definition" },
                    { new Guid("12d97781-b2ae-4c14-a06f-29260dc014c3"), "Forth Task Definition" },
                    { new Guid("57d9e2f0-a94b-45f6-9336-243d44d671e5"), "Third Task Definition" },
                    { new Guid("00e84b5a-0c4c-4a12-b30f-4083ac3870a3"), "Second Task Definition" },
                    { new Guid("b700bdc6-6d43-407a-beea-abab5f0362ef"), "First Task Definition" },
                    { new Guid("946907b3-0def-4755-9588-2244ba7a9927"), "Fifth Task Definition" },
                    { new Guid("dc7e6670-3cb7-4172-9299-c4face3ef21b"), "Forth Task Definition" },
                    { new Guid("abce83a9-99bc-4438-92a9-b88d6e2bf5e0"), "Third Task Definition" },
                    { new Guid("98584453-b679-4fb4-a010-559a8630ee12"), "Second Task Definition" },
                    { new Guid("4a1a12d9-4ccf-403f-b793-811253af1fe8"), "First Task Definition" },
                    { new Guid("34f7db72-fdb5-4d96-ad69-363aab868f9d"), "Fifth Task Definition" },
                    { new Guid("fbb132fa-1719-43b5-b6ae-4b397e2a3eda"), "Forth Task Definition" },
                    { new Guid("77f081ad-3182-4518-99fe-6d41b953afb7"), "Third Task Definition" },
                    { new Guid("567c5729-5b2f-41bf-8109-0406ecd5e4a0"), "Second Task Definition" },
                    { new Guid("137bc3f0-c272-4d0a-b9b7-1b670ac33d62"), "Forth Task Definition" },
                    { new Guid("1b8e73df-925f-4aec-b42c-25c64c206919"), "Fifth Task Definition" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("009d9721-f000-48e2-bfc6-3f47cda7db09"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("00e84b5a-0c4c-4a12-b30f-4083ac3870a3"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("03075a0c-d8dc-4748-ae19-f58c7b867ebc"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("092f31f1-f3b9-4520-810f-fa84d4d8a669"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0f0eac9a-2e45-4b16-9770-1b7d5c0cc54e"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("12d97781-b2ae-4c14-a06f-29260dc014c3"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("137bc3f0-c272-4d0a-b9b7-1b670ac33d62"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("158c4f6f-8f3e-42e8-8d48-c665eecbf7bc"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("15a8f876-4660-473f-954a-4487486d994a"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1a1ed31a-a7a3-4241-aede-4cf11660e419"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1b8e73df-925f-4aec-b42c-25c64c206919"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1bf58f00-bfa2-4b36-b47b-c67a49e9279f"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("251df60b-7c5d-4d38-87e3-55b3c07513d0"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("27f84c93-e406-40c0-a028-e3ea8700e6cb"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2da7c86b-7580-4b42-b270-2365f1b44579"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2e6ded76-70d7-48c1-a5a6-0bef84faf7d9"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2f007dc3-77b3-441a-ad08-a25ffdd15adf"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("318f6e70-9f42-4751-a32c-41f6d61988f4"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("32452074-3b67-4355-91b3-ecfd712f855a"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("34033c66-857f-4c46-9675-7c3b9e9e850e"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("34f7db72-fdb5-4d96-ad69-363aab868f9d"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("429474ae-0bcd-4146-a635-a34f7da7889a"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4a1a12d9-4ccf-403f-b793-811253af1fe8"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("50e0d147-2eb4-4e59-ac03-438a59634b2c"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("541f6662-1433-41a0-af79-971c9d4da00b"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5550c4e4-bdfb-4487-9b07-c56e12f7aa59"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("55fc4433-0a3a-4a99-bb9d-70bed1468265"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("56276848-c6be-4f73-8aa4-6015f6ceadf2"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("567c5729-5b2f-41bf-8109-0406ecd5e4a0"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("57d9e2f0-a94b-45f6-9336-243d44d671e5"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("685e0232-8b99-4af3-88de-bf7be53ac486"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7406edf3-6892-4814-932e-42af1adb3ba1"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("77f081ad-3182-4518-99fe-6d41b953afb7"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7dffd22b-9ea6-42d3-bc8f-8b029c996a4f"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7f76a3b0-1c5b-4d37-a92a-af99fa9eb6d8"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("81c92073-3a6b-4278-820f-f51d3e3cc617"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("86df2e57-b9d1-48f6-adf1-6f9888670fe7"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("872bc1f9-8d64-429c-baa7-371809200196"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("87790918-868c-4eec-8658-67f69c23ccae"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("888e4f34-7642-4198-a4df-fa6061c97b85"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8a69482d-1be7-4f62-a518-dc908a76e8f7"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("90cc32a7-1d57-4a1a-b514-c5b015f6afb9"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("938fd961-9a83-423f-893e-526b63631ffd"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("946907b3-0def-4755-9588-2244ba7a9927"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("94b1eb11-4d82-4bf0-a6fb-3e427ced9263"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("954b3c0a-388c-432a-bb2e-065be0c913f3"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("98584453-b679-4fb4-a010-559a8630ee12"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9cdab491-9d2b-4e85-8704-50d34df82b06"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9d689985-f69a-4287-8707-8d2f3c15ef07"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a3131ce0-d438-4797-b5eb-04c89d457221"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a81df56c-444d-46b6-8056-f4ad86d22a12"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a9057e15-893a-4447-bd93-2139b89f85e0"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("aaa18f55-9023-4b15-a947-24d8f6188920"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("abce83a9-99bc-4438-92a9-b88d6e2bf5e0"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("aff9a989-e345-4e19-8c2a-9436e28f3203"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b700bdc6-6d43-407a-beea-abab5f0362ef"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b7114429-84d5-4ab8-86dd-fbe41715babb"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bf7f07ee-b4aa-4a3c-9522-e04de38bd15f"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bfffc0f9-2564-4a80-89c8-af06bbdc3f5a"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c23bd24b-8f61-4d64-89ad-776a92eec02e"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c567dfb0-ca64-4344-bed7-3a0e2aa864c2"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c5ae59a2-88a7-4703-b8a5-d8417392b47e"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c807c14e-21c7-474e-891d-da4e4bea5dcc"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ce6bd23b-6256-4f33-9b73-7bd3e3494bbb"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("cfae5f6d-fb2f-4a88-b168-d723dd280bf6"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d68f48d0-7cd3-4788-8b08-cdadb2d65a62"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("da74fafd-11e2-4998-b789-3bea3ae2dc3f"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("dc7e6670-3cb7-4172-9299-c4face3ef21b"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("dd7fe925-3b69-4841-9dc7-9e3dd8836280"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ddbc7fc6-2c88-4906-9c62-4b1c668d3d1f"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e08d159d-a9b0-4949-afe1-d13548f3c072"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e0fd8527-58b4-48ce-82e6-f4db2bc8be19"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e413eda5-892d-4558-bad0-577a82f6a875"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e59db898-132e-4346-97ac-6a7b0c77d968"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ee045199-1eb7-43dc-8edf-87d1d4c07980"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f674d106-e9e9-437b-8f71-4879113eefaf"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f7ce4cdf-c1ab-4704-83e4-e345007dd44a"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("fbb132fa-1719-43b5-b6ae-4b397e2a3eda"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("fd95bb28-7acb-417b-a592-0f51a79d347a"));

            migrationBuilder.DeleteData(
                table: "TaskDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("fe8ed150-c34f-4e80-b135-f2551ddadc7e"));

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
    }
}
