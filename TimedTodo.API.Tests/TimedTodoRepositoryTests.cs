using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedTodo.API.Services;
using TimedTodo.API.Tests.Helpers;
using TimedTodo.Data;
using TimedTodo.Domain;

namespace TimedTodo.API.Tests
{
  [TestClass]
  public class TimedTodoRepositoryTests
  {
    private TaskDefinitionComparer taskDefinitionComparer = new TaskDefinitionComparer();

    [TestMethod]
    public async Task RepositoryCanGetTaskDefinition()
    {
      var builder = TestsHelper.SetupInMemoryDatabase(Guid.NewGuid().ToString());

      Guid taskDefinitionId = TestsHelper.SeedTaskDefinition(builder.Options);

      using (var context = new TimedTodoContext(builder.Options))
      {
        var repository = new TimedTodoRepository(context);
        var retrievedTaskDefinition = await repository.GetTaskDefinitionAsync(taskDefinitionId);
        Assert.AreEqual(taskDefinitionId, retrievedTaskDefinition.Id);
      }
    }

    [TestMethod]
    public async Task RepositoryWithoutTaskDefinitionReturnsNull()
    {
      var builder = TestsHelper.SetupInMemoryDatabase(Guid.NewGuid().ToString());

      using (var context = new TimedTodoContext(builder.Options))
      {
        var repository = new TimedTodoRepository(context);
        var taskDefinition = await repository.GetTaskDefinitionAsync(Guid.NewGuid());
        Assert.IsNull(taskDefinition);
      }
    }


    [TestMethod]
    public async Task RepositoryCanGetTaskDefinitions()
    {
      var builder = TestsHelper.SetupInMemoryDatabase(Guid.NewGuid().ToString());

      var seededTaskDefininitions = TestsHelper.SeedMultipleTaskDefinitions(builder.Options, 3)
        .OrderBy(t => t.Id).ToList();

      using (var context = new TimedTodoContext(builder.Options))
      {
        var repository = new TimedTodoRepository(context);
        var taskDefinitions = (await repository.GetTaskDefinitionsAsync()).OrderBy(t => t.Id).ToList();
        CollectionAssert.AreEqual(seededTaskDefininitions, taskDefinitions, taskDefinitionComparer);
      }
    }

    [TestMethod]
    public async Task RepositoryWithoutTaskDefinitionsReturnsEmptyList()
    {
      var builder = TestsHelper.SetupInMemoryDatabase(Guid.NewGuid().ToString());
      using (var context = new TimedTodoContext(builder.Options))
      {
        var repository = new TimedTodoRepository(context);
        var taskDefinitions = await repository.GetTaskDefinitionsAsync();
        Assert.IsTrue(taskDefinitions.ToList().Count == 0);
      }
    }
  }
}
