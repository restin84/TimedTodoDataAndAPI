﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimedTodo.Data;

namespace TimedTodo.Data.Migrations
{
    [DbContext(typeof(TimedTodoContext))]
    partial class TimedTodoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimedTodo.Domain.TaskDefinition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("DefaultTimeSpan")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskDefinitions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7c9f6d3-3d0e-4a3b-9918-ca3feb480f85"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 1"
                        },
                        new
                        {
                            Id = new Guid("ebb95554-897d-4e0e-8cda-a2c8c84f36df"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 2"
                        },
                        new
                        {
                            Id = new Guid("caef9a1f-860d-459f-ac12-838c3d713d39"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 3"
                        },
                        new
                        {
                            Id = new Guid("73bed43c-6917-48be-bae7-77da35f8cac9"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 4"
                        },
                        new
                        {
                            Id = new Guid("01851adb-dcc0-418d-8bd5-06214c512371"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 5"
                        },
                        new
                        {
                            Id = new Guid("9aa1baa1-7377-425e-a9e7-89b08288bf15"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 6"
                        },
                        new
                        {
                            Id = new Guid("48bd310a-8106-4df2-aff7-96d6f94c71e0"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 7"
                        },
                        new
                        {
                            Id = new Guid("f9a510b7-25db-4b2a-a9ab-97513ff9a932"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 8"
                        },
                        new
                        {
                            Id = new Guid("30bd93c2-f11d-4778-964f-3508a73da085"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 9"
                        },
                        new
                        {
                            Id = new Guid("e7e9c770-7556-4f95-85a0-dd94a48b27e9"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 10"
                        });
                });

            modelBuilder.Entity("TimedTodo.Domain.TaskInstance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("ElapsedTime")
                        .HasColumnType("time");

                    b.Property<Guid?>("TaskDefinitionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskDefinitionId");

                    b.ToTable("TaskInstances");
                });

            modelBuilder.Entity("TimedTodo.Domain.TaskInstance", b =>
                {
                    b.HasOne("TimedTodo.Domain.TaskDefinition", "TaskDefinition")
                        .WithMany()
                        .HasForeignKey("TaskDefinitionId");
                });
#pragma warning restore 612, 618
        }
    }
}
