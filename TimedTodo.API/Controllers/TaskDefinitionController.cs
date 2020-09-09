using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedTodo.API.Services;

namespace TimedTodo.API.Controllers
{
  [ApiController]
  [Route("api/taskdefinitions")]
  public class TaskDefinitionController : ControllerBase
  {
    private readonly ITimedTodoRepository timedTodoRepository;

    public TaskDefinitionController(ITimedTodoRepository timedTodoRepository) {
      this.timedTodoRepository = timedTodoRepository ??
        throw new ArgumentNullException(nameof(timedTodoRepository));
    }

    [HttpGet]
    public IActionResult GetTaskDefinitions() {
      var taskDefinitions = timedTodoRepository.GetTaskDefinitions();
      return new JsonResult(taskDefinitions);
    }

    [HttpGet("{taskDefinitionId}")]
    public IActionResult GetTaskDefinition(Guid taskDefinitionId) {
      return Ok();
    }
  }
}
