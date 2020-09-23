﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimedTodo.Domain;

namespace TimedTodo.API.Services
{
  public interface ITimedTodoRepository
  {
    public TaskDefinition GetTaskDefinition(Guid taskDefinitionId);
    public IEnumerable<TaskDefinition> GetTaskDefinitions();

    public Task<TaskDefinition> GetTaskDefinitionAsync(Guid taskDefinitionId);

    public Task<IEnumerable<TaskDefinition>> GetTaskDefinitionsAsync();

    public void AddTaskDefinition(TaskDefinition taskDefinition);

    public Task<bool> SaveChangesAsync();
  }
}
