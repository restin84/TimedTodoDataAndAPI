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
    public const string TitleEmptyError = "Title cannot be empty";
    public const string HoursGreaterThanOrEqualToZeroError = "Hours must be greater than or equal to 0";
    public const string MinutesGreaterThanOrEqualToZeroError = "Minutes must be greater than or equal to 0";
    public const string SecondsGreaterThanOrEqualToZeroError = "Seconds must be greater than or equal to 0";
   
    public TaskDefinitionForCreationDtoValidator()
    {
      RuleFor(x => x.Title)
        .NotEmpty()
        .WithMessage(TitleEmptyError);
      RuleFor(x => x.Hours)
        .GreaterThanOrEqualTo(0)
        .WithMessage(HoursGreaterThanOrEqualToZeroError);
      RuleFor(x => x.Minutes).
        GreaterThanOrEqualTo(0)
        .WithMessage(MinutesGreaterThanOrEqualToZeroError);
      RuleFor(x => x.Seconds)
        .GreaterThanOrEqualTo(0)
        .WithMessage(SecondsGreaterThanOrEqualToZeroError);
    }
  }
}
