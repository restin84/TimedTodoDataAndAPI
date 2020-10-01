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
      CreateMap<TaskDefinition, TaskDefinitionDto>()
        .ForMember(dest => dest.Hours, opt => opt.MapFrom(src =>
          src.DefaultTimeSpan.Hours))
        .ForMember(dest => dest.Minutes, opt => opt.MapFrom(src =>
          src.DefaultTimeSpan.Minutes))
        .ForMember(dest => dest.Seconds, opt => opt.MapFrom(src =>
          src.DefaultTimeSpan.Seconds));
    }
  }
}
