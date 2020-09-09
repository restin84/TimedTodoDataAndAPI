using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedTodo.Domain;

namespace TimedTodo.API.Services
{
  public interface ITimedTodoRepository
  {
    public TaskDefinition GetTaskDefinition(Guid taskDefinitionId);
    public IEnumerable<TaskDefinition> GetTaskDefinitions();
  }
}
