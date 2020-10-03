using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimedTodo.Domain;

namespace TimedTodo.API.Services
{
  public interface ITimedTodoRepository
  {

    public Task<TaskDefinition> GetTaskDefinitionAsync(Guid taskDefinitionId);

    public Task<IEnumerable<TaskDefinition>> GetTaskDefinitionsAsync();

    public Task<IEnumerable<TaskDefinition>> GetTaskDefinitionsAsync(IEnumerable<Guid> taskDefinitionIds);

    public void AddTaskDefinition(TaskDefinition taskDefinition);

    public Task<bool> SaveChangesAsync();
  }
}
