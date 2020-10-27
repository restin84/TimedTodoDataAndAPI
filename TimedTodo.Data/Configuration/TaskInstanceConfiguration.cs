using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Text;
using TimedTodo.Domain;

namespace TimedTodo.Data.Configuration
{
  public class TaskInstanceConfiguration : IEntityTypeConfiguration<TaskInstance>
  {
    public void Configure(EntityTypeBuilder<TaskInstance> builder)
    {
      builder.Ignore(t => t.ElapsedTime);
      builder.Property(t => t.ElapsedTime)
        .HasConversion(new TimeSpanToTicksConverter());
      //builder.HasOne(t => t.TaskDefinition)
      //  .WithOne()
      //  .
    }
  }
}
