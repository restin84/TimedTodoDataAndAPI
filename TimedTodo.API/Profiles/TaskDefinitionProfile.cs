using AutoMapper;
using System;
using TimedTodo.API.Models;
using TimedTodo.Domain;

namespace TimedTodo.API.Profiles
{
  public class TaskDefinitionProfile : Profile
  {
    public TaskDefinitionProfile()
    {
      CreateMap<TaskDefinitionForCreationDto, TaskDefinition>()
        .ForMember(dest => dest.DefaultTimeSpan, opt => opt.MapFrom(src =>
          new TimeSpan(src.Hours, src.Minutes, src.Seconds)));
    }
  }
}
