using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedTodo.Data;
using TimedTodo.Domain;

namespace TimedTodo.API.Services
{
  public class TimedTodoRepository : ITimedTodoRepository
  {

    private readonly TimedTodoContext timedTodoContext;

    public TimedTodoRepository(TimedTodoContext timedTodoContext) {
      this.timedTodoContext = timedTodoContext  ?? 
        throw new ArgumentNullException(nameof(timedTodoContext));
    }

    public TaskDefinition GetTaskDefinition(Guid taskDefinitionId) {
      throw new NotImplementedException();
    }

    public IEnumerable<TaskDefinition> GetTaskDefinitions() {
      return timedTodoContext.TaskDefinitions.ToList();
    }
  }
}
