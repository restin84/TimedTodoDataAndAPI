﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimedTodo.Data;

namespace TimedTodo.Data.Migrations
{
    [DbContext(typeof(TimedTodoContext))]
    [Migration("20201023032109_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
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
                            Id = new Guid("a96a7984-ffd0-4654-8f89-0298db3903bd"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 1"
                        },
                        new
                        {
                            Id = new Guid("e5da4dc2-c1e9-4341-9756-9639767a3512"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 2"
                        },
                        new
                        {
                            Id = new Guid("d0d52735-2d38-42ed-97bd-8a099c1b07a1"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 3"
                        },
                        new
                        {
                            Id = new Guid("b16a23ee-76c8-4ebf-ac3f-f70c3a3e5573"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 4"
                        },
                        new
                        {
                            Id = new Guid("e22b9297-5797-47f4-ba9e-61b392d86f09"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 5"
                        },
                        new
                        {
                            Id = new Guid("542b7286-41b4-4e9c-9404-41186763d37e"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 6"
                        },
                        new
                        {
                            Id = new Guid("f0f44299-9c0f-4ba9-99fe-c10fc42e923d"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 7"
                        },
                        new
                        {
                            Id = new Guid("88506f88-a7f5-4493-83ec-8a87f921d666"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 8"
                        },
                        new
                        {
                            Id = new Guid("f03fe60b-e441-46f3-90b0-d7f73891debf"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 9"
                        },
                        new
                        {
                            Id = new Guid("404b9dd4-6872-4ab1-8d2f-4034c75fc055"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 10"
                        });
                });

            modelBuilder.Entity("TimedTodo.Domain.TaskInstance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ElapsedTime")
                        .HasColumnType("bigint");

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