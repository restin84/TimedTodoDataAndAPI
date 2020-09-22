using System;
using System.Collections.Generic;
using System.Text;

namespace TimedTodo.Domain
{
  public class TaskDefinition
  {
    public Guid Id { get; set; }
    public string Title { get; set; }
    public long DefaultTimeSpan { get; set; }

  }
}
