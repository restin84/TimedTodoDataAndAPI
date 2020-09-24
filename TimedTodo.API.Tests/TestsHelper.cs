using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimedTodo.Data;
using TimedTodo.Domain;

namespace TimedTodo.API.Tests
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

    public static DbContextOptionsBuilder<TimedTodoContext> SetupInMemoryDatabase(string databaseName)
    {
      var builder = new DbContextOptionsBuilder<TimedTodoContext>();
      builder.UseInMemoryDatabase(databaseName);
      return builder;
    }
  }
}
