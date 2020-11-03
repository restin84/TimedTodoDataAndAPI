using FluentValidation.TestHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TimedTodo.API.Models;
using TimedTodo.API.Tests.Helpers;
using TimedTodo.API.Validation;

namespace TimedTodo.API.Tests.Validation
{
  [TestClass]
  public class TaskDefinitionForCreationDtoValidatorTests
  {
    private TaskDefinitionForCreationDtoValidator validator;

    [TestInitialize]
    public void Setup()
    {
      validator = new TaskDefinitionForCreationDtoValidator();
    }

    [TestMethod] 
    public void SecondsLessThanZeroResultsInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 1, 0, -1);
      var result = validator.TestValidate(dto);
      result.ShouldHaveValidationErrorFor(dto => dto.Seconds);
    }
  }
}
