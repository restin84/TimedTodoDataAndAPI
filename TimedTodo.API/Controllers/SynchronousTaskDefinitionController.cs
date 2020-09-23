using Microsoft.AspNetCore.Mvc;
using System;
using TimedTodo.API.Services;

namespace TimedTodo.API.Controllers
{
  [ApiController]
  [Route("api/synchronoustaskdefinitions")]
  public class SynchronousTaskDefinitionController : ControllerBase
  {
    private readonly ITimedTodoRepository timedTodoRepository;

    public SynchronousTaskDefinitionController(ITimedTodoRepository timedTodoRepository)
    {
      this.timedTodoRepository = timedTodoRepository ??
        throw new ArgumentNullException(nameof(timedTodoRepository));
    }

    [HttpGet]
    public IActionResult GetTaskDefinitions()
    {
      var taskDefinitions = timedTodoRepository.GetTaskDefinitions();
      return Ok(taskDefinitions);
    }
  }
}
