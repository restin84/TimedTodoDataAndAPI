using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TimedTodo.Data.Configuration;
using TimedTodo.Domain;

namespace TimedTodo.Data
{
  public class TimedTodoContext : DbContext
  {
    public DbSet<TaskDefinition> TaskDefinitions { get; set; }
    public DbSet<TaskInstance> TaskInstances { get; set; }
    //TODO: Should this be removed or left around so that I can use the 
    //context from a console app?
    ////We need a ILoggerFactory to supply to the UseLoggerFactory method
    public static readonly ILoggerFactory ConsoleLoggerFactory =
      LoggerFactory.Create(builder =>
      {
        builder
          .AddFilter((category, level) =>
            category == DbLoggerCategory.Database.Command.Name
            && level == LogLevel.Information).AddConsole();
      });

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder
            .UseLoggerFactory(ConsoleLoggerFactory)
            .UseSqlServer(
              @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TimedTodoData"); 
      }
    }

    public TimedTodoContext(DbContextOptions<TimedTodoContext> options) : base(options)
    {
      ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public TimedTodoContext()
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new TaskDefinitionConfiguration());
      modelBuilder.ApplyConfiguration(new TaskInstanceConfiguration());
      //modelBuilder.Entity<TaskInstance>()
      //  .Property(t => t.ElapsedTime)
      //  .HasConversion(new TimeSpanToTicksConverter());

      int numTaskDefs = 10;
      var taskDefs = new List<TaskDefinition>(numTaskDefs);
      for (int i = 0; i < numTaskDefs; i++)
      {
        taskDefs.Add(
          new TaskDefinition
          {
            Id = Guid.NewGuid(),
            Title = $"TaskDefinition {i + 1}",
            DefaultTimeSpan = new TimeSpan()
          }
          );
      }
      modelBuilder.Entity<TaskDefinition>().HasData(
          taskDefs
        );
      base.OnModelCreating(modelBuilder);
    }
  }
}
