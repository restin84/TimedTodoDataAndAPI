using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimedTodo.Domain
{
  public class TaskDefinition
  {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public TimeSpan DefaultTimeSpan { get; set; }
    public List<TaskInstance> TaskInstances { get; set; }

  }
}
