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
    [Migration("20201027024806_ChangedTaskInstanceConfiguration")]
    partial class ChangedTaskInstanceConfiguration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskDefinitions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d60a20a0-76fc-4f64-9f08-b194e8a6ffdb"),
                            Title = "TaskDefinition 1"
                        },
                        new
                        {
                            Id = new Guid("a9b66aba-9170-4379-9172-1f0b9233c3a6"),
                            Title = "TaskDefinition 2"
                        },
                        new
                        {
                            Id = new Guid("bd6eaaff-a9f6-4fb8-9fd5-b8594f4fbef1"),
                            Title = "TaskDefinition 3"
                        },
                        new
                        {
                            Id = new Guid("18e36009-a1cf-4d2b-9094-fc605a99f212"),
                            Title = "TaskDefinition 4"
                        },
                        new
                        {
                            Id = new Guid("bdcbcf75-0b13-42b7-85dd-4e01c5fa4091"),
                            Title = "TaskDefinition 5"
                        },
                        new
                        {
                            Id = new Guid("5a31a753-ff59-46b7-af1f-33eabddde031"),
                            Title = "TaskDefinition 6"
                        },
                        new
                        {
                            Id = new Guid("089ae43d-2f2a-4bd8-8b6b-37c1e0b98685"),
                            Title = "TaskDefinition 7"
                        },
                        new
                        {
                            Id = new Guid("783c476a-c01e-4b99-9836-a19bb1601b39"),
                            Title = "TaskDefinition 8"
                        },
                        new
                        {
                            Id = new Guid("a0e3ce30-535c-40c9-87f2-d12e16e0a1ce"),
                            Title = "TaskDefinition 9"
                        },
                        new
                        {
                            Id = new Guid("b2e148ac-6ead-4efe-babe-c6dd7380e1db"),
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
