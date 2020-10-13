using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedTodo.API.Filters;
using TimedTodo.API.ModelBinders;
using TimedTodo.API.Models;
using TimedTodo.API.Services;
using TimedTodo.Domain;

namespace TimedTodo.API.Controllers
{
  [ApiController]
  [Route("api/taskdefinitioncollections")]
  [TaskDefinitionsResultFilter]
  public class TaskDefinitionCollectionsController : ControllerBase
  {
    private readonly ITimedTodoRepository timedTodoRepository;
    private readonly IMapper mapper;

    public TaskDefinitionCollectionsController(ITimedTodoRepository timedTodoRepository,
      IMapper mapper)
    {
      this.timedTodoRepository = timedTodoRepository ??
        throw new ArgumentNullException(nameof(timedTodoRepository));
      this.mapper = mapper ??
        throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet("({taskDefinitionIds})", Name = "GetTaskDefinitionCollection")]
    public async Task<IActionResult> GetTaskDefinitionCollection(
      [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> taskDefinitionIds)
    {
      var taskDefinitionEntities = await timedTodoRepository.GetTaskDefinitionsAsync(taskDefinitionIds);

      if (taskDefinitionIds.Count() != taskDefinitionEntities.Count())
      {
        return NotFound();
      }

      return Ok(taskDefinitionEntities);
    }

    [HttpPost]
    //TODO: validation
    public async Task<IActionResult> CreateTaskDefinitionCollection(
      IEnumerable<TaskDefinitionForCreationDto> taskDefinitionCollection)
    {
      var taskDefinitionEntities = mapper.Map<IEnumerable<TaskDefinition>>(taskDefinitionCollection);


      foreach (var taskDefinition in taskDefinitionEntities)
      {
        timedTodoRepository.AddTaskDefinition(taskDefinition);
      }

      await timedTodoRepository.SaveChangesAsync();

      var taskDefinitionsToReturn = await timedTodoRepository.GetTaskDefinitionsAsync(
        taskDefinitionEntities.Select(t => t.Id).ToList());

      var taskDefinitionIds = string.Join(',', taskDefinitionsToReturn.Select(t => t.Id).ToList());

      return CreatedAtRoute(
        "GetTaskDefinitionCollection",
        new { taskDefinitionIds },
        taskDefinitionsToReturn);
    }
  }
}
