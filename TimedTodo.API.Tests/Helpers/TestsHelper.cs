using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimedTodo.Data;
using TimedTodo.Domain;

namespace TimedTodo.API.Tests.Helpers
{
  public class TestsHelper
  {
    public static Guid SeedTaskDefinition(DbContextOptions<TimedTodoContext> options)
    {
      using (var context = new TimedTodoContext(options))
      {
        var taskDefinition = new TaskDefinition();
        context.Add(taskDefinition);
        context.SaveChanges();
        return taskDefinition.Id;
      }
    }

    public static IList<TaskDefinition> SeedMultipleTaskDefinitions(
      DbContextOptions<TimedTodoContext> options, int numberToSeed)
    {
      List<TaskDefinition> taskDefs = new List<TaskDefinition>();
      for (int i = 0; i < numberToSeed; i++)
      {
        taskDefs.Add(new TaskDefinition() { Title = $"TaskDefinition {i}" });
      }
      using (var context = new TimedTodoContext(options))
      {
        context.AddRange(taskDefs);
        context.SaveChanges();
      }
      return taskDefs;
    }

    public static DbContextOptionsBuilder<TimedTodoContext> SetupInMemoryDatabase(string databaseName)
    {
      var builder = new DbContextOptionsBuilder<TimedTodoContext>();
      builder.UseInMemoryDatabase(databaseName);
      return builder;
    }
  }
}
