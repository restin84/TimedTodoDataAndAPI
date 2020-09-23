using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;

namespace TimedTodo.API
{
  public class Program
  {

    public static void Main(string[] args)
    {
      //throttle the thread pool (set available threads to the number of processors)
      ThreadPool.SetMaxThreads(Environment.ProcessorCount, Environment.ProcessorCount);

      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
