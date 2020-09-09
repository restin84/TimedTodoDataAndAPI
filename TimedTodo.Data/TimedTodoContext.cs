using Microsoft.EntityFrameworkCore;
using TimedTodo.Domain;

namespace TimedTodo.Data
{
  public class TimedTodoContext : DbContext
  {
    public DbSet<TaskDefinition> TaskDefinitions { get; set; }

    //TODO: Should this be removed or left around so that I can use the 
    //context from a console app?
    ////We need a ILoggerFactory to supply to the UseLoggerFactory method
    //public static readonly ILoggerFactory ConsoleLoggerFactory =
    //  LoggerFactory.Create(builder => {
    //    builder
    //      .AddFilter((category, level) =>
    //        category == DbLoggerCategory.Database.Command.Name
    //        && level == LogLevel.Information).AddConsole();
    //  });

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
    //  optionsBuilder
    //    .UseLoggerFactory(ConsoleLoggerFactory)
    //    .UseSqlServer(
    //      @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TimedTodoData");
    //}

    public TimedTodoContext(DbContextOptions<TimedTodoContext> options) : base(options) {
      ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
  }
}
