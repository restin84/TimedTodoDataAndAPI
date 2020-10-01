﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedTodo.API.Models;

namespace TimedTodo.API.Filters
{
  public class TaskDefinitionResultFilterAttribute : ResultFilterAttribute
  {
    public override async Task OnResultExecutionAsync(
      ResultExecutingContext context, 
      ResultExecutionDelegate next)
    {
      var resultFromAction = context.Result as ObjectResult;
      if (resultFromAction?.Value == null
        || resultFromAction.StatusCode < 200
        || resultFromAction.StatusCode >= 300)
      {
        await next();
        return;
      }

      var mapper = context.HttpContext.RequestServices.GetRequiredService<IMapper>();

      resultFromAction.Value = mapper.Map<TaskDefinitionDto>(resultFromAction.Value);

      await next();
    }
  }
}
