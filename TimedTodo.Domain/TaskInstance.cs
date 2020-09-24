using System;
using System.Collections.Generic;
using System.Text;

namespace TimedTodo.Domain
{
  public class TaskInstance
  {
    public Guid Id { get; set; }
    public TimeSpan ElapsedTime { get; set; }
    public TaskDefinition TaskDefinition { get; set; }
  }
}
