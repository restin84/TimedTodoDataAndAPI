using System;
using System.Collections.Generic;
using System.Text;

namespace TimedTodo.Domain
{
  public class TaskDefinition
  {
    public Guid Id { get; set; }
    public string Title { get; set; }
    //TODO: Figure out timespan for default time
  }
}
