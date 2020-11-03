using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedTodo.API.Models;

namespace TimedTodo.API.Validation
{
  public class TaskDefinitionForCreationDtoValidator : AbstractValidator<TaskDefinitionForCreationDto>
  {
    public TaskDefinitionForCreationDtoValidator()
    {
      RuleFor(x => x.Title).NotEmpty();
      RuleFor(x => x.Hours).GreaterThanOrEqualTo(0);
      RuleFor(x => x.Minutes).GreaterThanOrEqualTo(0);
      RuleFor(x => x.Seconds).GreaterThanOrEqualTo(0);
    }

    
  }
}
