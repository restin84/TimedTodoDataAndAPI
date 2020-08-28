using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TimedTodo.Domain;

namespace TimedTodo.Data
{
  public class TimedTodoContext : DbContext
  {
    public DbSet<TaskDefinition> TaskDefinitions { get; set; }

    //We need a ILoggerFactory to supply to the UseLoggerFactory method
    public static readonly ILoggerFactory ConsoleLoggerFactory =
      LoggerFactory.Create(builder => {
        builder
          .AddFilter((category, level) =>
            category == DbLoggerCategory.Database.Command.Name
            && level == LogLevel.Information).AddConsole();
      });

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder
        .UseLoggerFactory(ConsoleLoggerFactory)
        .UseSqlServer(
          @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TimedTodoData");
    }
  }
}
