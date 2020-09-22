using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TimedTodo.Domain
{
  public class TaskDefinition
  {
    public Guid Id { get; set; }
    public string Title { get; set; }
    [NotMapped]
    public TimeSpan DefaultTimeSpan { get; set; }

  }
}
