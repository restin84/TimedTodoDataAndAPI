using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using TimedTodo.Domain;

namespace TimedTodo.API.Tests.Helpers
{
  public class TaskDefinitionComparer : Comparer<TaskDefinition>
  {
    public override int Compare([AllowNull] TaskDefinition x, [AllowNull] TaskDefinition y)
    {
      int compareToResult = x.Id.CompareTo(y.Id);
      if (compareToResult == 0)
      {
        compareToResult = x.DefaultTimeSpan.CompareTo(y.DefaultTimeSpan);
        if (compareToResult == 0)
        {
          compareToResult = x.Title.CompareTo(y.Title);
        }
      }
      return compareToResult;
    }
  }
}
