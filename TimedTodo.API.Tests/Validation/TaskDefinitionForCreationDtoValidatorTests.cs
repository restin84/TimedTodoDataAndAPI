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
      result.ShouldHaveValidationErrorFor(dto => dto.Seconds)
        .WithErrorMessage(TaskDefinitionForCreationDtoValidator.SecondsGreaterThanOrEqualToZeroError);
    }

    [TestMethod]
    public void ZeroSecondsDoesNotResultInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 1, 0, 0);
      var result = validator.TestValidate(dto);
      result.ShouldNotHaveAnyValidationErrors();
    }

    [TestMethod]
    public void OneSecondsDoesNotResultInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 1, 0, 1);
      var result = validator.TestValidate(dto);
      result.ShouldNotHaveAnyValidationErrors();
    }

    [TestMethod]
    public void MinutesLessThanZeroResultsInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 0, -1, 0);
      var result = validator.TestValidate(dto);
      result.ShouldHaveValidationErrorFor(dto => dto.Minutes)
        .WithErrorMessage(TaskDefinitionForCreationDtoValidator.MinutesGreaterThanOrEqualToZeroError);
    }

    [TestMethod]
    public void ZeroMinutesDoesNotResultInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 0, 0, 0);
      var result = validator.TestValidate(dto);
      result.ShouldNotHaveAnyValidationErrors();
    }

    [TestMethod]
    public void OneMinutesDoesNotResultInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 0, 1, 0);
      var result = validator.TestValidate(dto);
      result.ShouldNotHaveAnyValidationErrors();
    }

    [TestMethod]
    public void HoursLessThanZeroResultsInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", -1, 0, 0);
      var result = validator.TestValidate(dto);
      result.ShouldHaveValidationErrorFor(dto => dto.Hours)
        .WithErrorMessage(TaskDefinitionForCreationDtoValidator.HoursGreaterThanOrEqualToZeroError);
    }

    [TestMethod]
    public void ZeroHoursDoesNotResultInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 0, 0, 0);
      var result = validator.TestValidate(dto);
      result.ShouldNotHaveAnyValidationErrors();
    }

    [TestMethod]
    public void OneHoursDoesNotResultInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 1, 0, 0);
      var result = validator.TestValidate(dto);
      result.ShouldNotHaveAnyValidationErrors();
    }

    [TestMethod]
    public void EmptyTitleResultsInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("", 0, 0, 0);
      var result = validator.TestValidate(dto);
      result.ShouldHaveValidationErrorFor(dto => dto.Title)
        .WithErrorMessage(TaskDefinitionForCreationDtoValidator.TitleEmptyError);
    }

    [TestMethod]
    public void NonEmptyTitleDoesNotResultInError()
    {
      var dto = TestsHelper.GetTaskDefinitionForCreationDto("Test", 0, 0, 0);
      var result = validator.TestValidate(dto);
      result.ShouldNotHaveAnyValidationErrors();
    }

  }
}
