using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TimedTodo.Domain
{
  public class TaskInstance
  {
    public Guid Id { get; set; }
    [NotMapped]
    public TimeSpan ElapsedTime { get; set; }
    [ForeignKey("TaskDefinitionId")]
    public TaskDefinition TaskDefinition { get; set; }
  }
}
