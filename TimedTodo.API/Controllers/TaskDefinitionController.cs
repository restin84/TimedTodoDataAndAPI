﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TimedTodo.API.Models;
using TimedTodo.API.Services;
using TimedTodo.Domain;

namespace TimedTodo.API.Controllers
{
  [ApiController]
  [Route("api/taskdefinitions")]
  public class TaskDefinitionController : ControllerBase
  {
    private readonly ITimedTodoRepository timedTodoRepository;
    private readonly IMapper mapper;

    public TaskDefinitionController(ITimedTodoRepository timedTodoRepository,
      IMapper mapper)
    {
      this.timedTodoRepository = timedTodoRepository ??
        throw new ArgumentNullException(nameof(timedTodoRepository));
      this.mapper = mapper ??
        throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<IActionResult> GetTaskDefinitions()
    {
      var taskDefinitions = await timedTodoRepository.GetTaskDefinitionsAsync();
      return Ok(taskDefinitions);
    }

    [HttpGet("{taskDefinitionId}")]
    [Route("{id}", Name = "GetTaskDefinition")]
    //TODO: add filter for return Dto
    public async Task<IActionResult> GetTaskDefinition(Guid taskDefinitionId)
    {
      var taskDefinition = await timedTodoRepository.GetTaskDefinitionAsync(taskDefinitionId);
      if (taskDefinition == null)
      {
        return NotFound();
      }
      return Ok(taskDefinition);
    }

    [HttpPost]
    //TODO: add filter for return Dto
    public async Task<IActionResult> CreateTaskDefinition(TaskDefinitionForCreationDto taskDefinitionForCreation)
    {
      var taskDefinitionEntity = mapper.Map<TaskDefinition>(taskDefinitionForCreation);

      timedTodoRepository.AddTaskDefinition(taskDefinitionEntity);

      await timedTodoRepository.SaveChangesAsync();

      return CreatedAtRoute(
        "GetTaskDefinition",
        new { id = taskDefinitionEntity.Id },
        taskDefinitionEntity);
    }
  }
}
