using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimedTodo.API.Controllers;
using TimedTodo.API.Services;
using TimedTodo.API.Tests.Helpers;
using TimedTodo.Domain;

namespace TimedTodo.API.Tests.Controllers
{
  [TestClass]
  public class TaskDefinitionsControllerTests
  {
    private Mock<ITimedTodoRepository> mockRepo;
    private Mock<IMapper> mockMapper;
    private TaskDefinitionsController taskDefinitionsController;

    [TestInitialize]
    public void Setup()
    {
      mockRepo = new Mock<ITimedTodoRepository>();
      mockMapper = new Mock<IMapper>();
      taskDefinitionsController = new TaskDefinitionsController(mockRepo.Object,
        mockMapper.Object);
    }

    [TestMethod]
    public async Task GetTaskDefinitionsReturnsAllTaskDefinitions()
    {
      mockRepo.Setup(repo => repo.GetTaskDefinitionsAsync())
        .ReturnsAsync(TestsHelper.GetTaskDefinitions(3))
        .Verifiable();

      var actionResult = await taskDefinitionsController.GetTaskDefinitions();
      var okResult = actionResult as OkObjectResult;
      var values = okResult.Value as IEnumerable<TaskDefinition>;

      Assert.IsNotNull(values);
      Assert.AreEqual(values.Count(), 3);
      mockRepo.Verify();
    }

    [TestMethod]
    public async Task GetTaskDefinitionsWithNoTaskDefinitionsReturnsOkWithNoTaskDefinitions()
    {
      mockRepo.Setup(repo => repo.GetTaskDefinitionsAsync())
        .ReturnsAsync(TestsHelper.GetTaskDefinitions(0))
        .Verifiable();

      var actionResult = await taskDefinitionsController.GetTaskDefinitions();
      var okResult = actionResult as OkObjectResult;
      var values = okResult.Value as IEnumerable<TaskDefinition>;

      Assert.IsInstanceOfType(okResult, typeof(OkObjectResult));
      Assert.IsNotNull(values);
      Assert.AreEqual(values.Count(), 0);
      mockRepo.Verify();
    }
    
    [TestMethod]
    public async Task GetTaskDefinitionWithValidIdReturnsOk()
    {
      TaskDefinition validTaskDefinition = TestsHelper.GetTaskDefinitions(1).First();
      mockRepo.Setup(repo => repo.GetTaskDefinitionAsync(It.IsAny<Guid>()))
        .ReturnsAsync(validTaskDefinition)
        .Verifiable();

      var actionResult = await taskDefinitionsController.GetTaskDefinition(Guid.NewGuid());
      var okResult = actionResult as OkObjectResult;
      var value = okResult.Value as TaskDefinition;

      Assert.IsInstanceOfType(okResult, typeof(OkObjectResult));
      Assert.AreEqual(value.Id, validTaskDefinition.Id);
    }

    [TestMethod]
    public async Task GetTaskDefinitionWithInvalidIdReturnsNotFound()
    {
      TaskDefinition nullTaskDefinition = null;
      mockRepo.Setup(repo => repo.GetTaskDefinitionAsync(It.IsAny<Guid>()))
        .ReturnsAsync(nullTaskDefinition)
        .Verifiable();

      var actionResult = await taskDefinitionsController.GetTaskDefinition(Guid.NewGuid());
      var notFoundResult = actionResult as NotFoundResult;

      Assert.IsNotNull(notFoundResult);
      mockRepo.Verify();
    }



  }
}
