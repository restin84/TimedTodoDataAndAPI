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
    [Migration("20201027025603_TweakingTaskDefinitionConfig")]
    partial class TweakingTaskDefinitionConfig
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

                    b.Property<long>("DefaultTimeSpan")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskDefinitions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b3c83c3-79dd-442e-a27e-1b8651a601d9"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 1"
                        },
                        new
                        {
                            Id = new Guid("aa3c9f0b-6154-4f59-a758-a03ae16708fd"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 2"
                        },
                        new
                        {
                            Id = new Guid("da8a0c18-718d-40e0-936a-ee3f09deb47c"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 3"
                        },
                        new
                        {
                            Id = new Guid("b4b920d9-8be2-4db5-8992-ffef3ac2fbcb"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 4"
                        },
                        new
                        {
                            Id = new Guid("b0600f6a-7f45-4520-81ec-03e05e03f35a"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 5"
                        },
                        new
                        {
                            Id = new Guid("9a33fc01-97fe-4f26-a7be-34c6a34a057b"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 6"
                        },
                        new
                        {
                            Id = new Guid("874e2796-bb10-49bc-80a3-2b8a4508df2f"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 7"
                        },
                        new
                        {
                            Id = new Guid("7733ab57-ead3-4bad-99b8-e1a00fb44afa"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 8"
                        },
                        new
                        {
                            Id = new Guid("bd14b320-0773-4ccc-80fd-10cdacbe2442"),
                            DefaultTimeSpan = 0L,
                            Title = "TaskDefinition 9"
                        },
                        new
                        {
                            Id = new Guid("213a9b0c-eace-4118-b16b-7890bc3de82c"),
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
