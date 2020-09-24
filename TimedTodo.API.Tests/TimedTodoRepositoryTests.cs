using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using TimedTodo.API.Services;
using TimedTodo.Data;

namespace TimedTodo.API.Tests
{
  [TestClass]
  public class TimedTodoRepositoryTests
  {
    [TestMethod]
    public async Task RepositoryCanGetTaskDefinition()
    {
      var builder = new DbContextOptionsBuilder<TimedTodoContext>();
      builder.UseInMemoryDatabase("GetTaskDefinition");

      Guid taskDefinitionId = TestsHelper.SeedTaskDefinition(builder.Options);

      using (var context = new TimedTodoContext(builder.Options))
      {
        var repository = new TimedTodoRepository(context);
        var retrievedTaskDefinition = await repository.GetTaskDefinitionAsync(taskDefinitionId);
        Assert.AreEqual(taskDefinitionId, retrievedTaskDefinition.Id);
      }

    }

  }
}
