using System;
using TimedTodo.Data;
using TimedTodo.Domain;

namespace TimedTodoConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      TimedTodoContext timedTodoContext = new TimedTodoContext();
      var taskDefinition = new TaskDefinition() { Title = "My first task def" };
      timedTodoContext.TaskDefinitions.Add(taskDefinition);
      var taskInstance = new TaskInstance
      {
        TaskDefinition = taskDefinition,
        TotalTime = new TimeSpan(),
        ElapsedTime = new TimeSpan()
      };
      timedTodoContext.TaskInstances.Add(taskInstance);
      timedTodoContext.SaveChanges();


      Console.WriteLine("hey");
    }
  }
}
