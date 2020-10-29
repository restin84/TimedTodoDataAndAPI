using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;
using TimedTodo.Domain;

namespace TimedTodo.Data.Configuration
{
  public class TaskDefinitionConfiguration : IEntityTypeConfiguration<TaskDefinition>
  {
    public void Configure(EntityTypeBuilder<TaskDefinition> builder)
    {
      builder.Ignore(t => t.DefaultTimeSpan);
      builder.Property(t => t.DefaultTimeSpan)
        .HasConversion(new TimeSpanToTicksConverter());
      builder.Property(t => t.Title)
        .HasMaxLength(256);
      
    }
  }
}
