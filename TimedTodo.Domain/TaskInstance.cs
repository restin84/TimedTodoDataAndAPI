using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TimedTodo.Domain
{
  public class TaskInstance
  {
    public Guid Id { get; set; }
    public TimeSpan ElapsedTime { get; set; }

    public Guid TaskDefinitionId { get; set; }
    public TaskDefinition TaskDefinition { get; set; }
  }
}
