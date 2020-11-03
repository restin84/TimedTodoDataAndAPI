using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimedTodo.API.Models;
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

    public static IEnumerable<TaskDefinition> SeedMultipleTaskDefinitions(
      DbContextOptions<TimedTodoContext> options, int numberToSeed)
    {
      IEnumerable<TaskDefinition> taskDefs = GetTaskDefinitions(numberToSeed);
      using (var context = new TimedTodoContext(options))
      {
        context.AddRange(taskDefs);
        context.SaveChanges();
      }
      return taskDefs;
    }

    public static IEnumerable<TaskDefinition> GetTaskDefinitions(int numberOfTaskDefs)
    {
      IList<TaskDefinition> taskDefs = new List<TaskDefinition>();
      for (int i = 0; i < numberOfTaskDefs; i++)
      {
        taskDefs.Add(new TaskDefinition() { Title = $"TaskDefinition {i}" });
      }
      return taskDefs;
    }

    public static DbContextOptionsBuilder<TimedTodoContext> SetupInMemoryDatabase(string databaseName)
    {
      var builder = new DbContextOptionsBuilder<TimedTodoContext>();
      builder.UseInMemoryDatabase(databaseName);
      return builder;
    }

    public static TaskDefinitionForCreationDto GetTaskDefinitionForCreationDto(string title,
      int hours, int minutes, int seconds)
    {
      var dto = new TaskDefinitionForCreationDto()
      {
        Title = title,
        Hours = hours,
        Minutes = minutes,
        Seconds = seconds
      };
      return dto;
    }
  }
}
