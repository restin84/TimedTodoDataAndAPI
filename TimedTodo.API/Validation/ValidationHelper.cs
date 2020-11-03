using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimedTodo.API.Validation
{
  public class ValidationHelper
  {
    private static bool ValidMinutesOrSeconds(int minutesOrSeconds)
    {
      return minutesOrSeconds >= 0 && minutesOrSeconds <= 59;
    }
  }
}
