using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using TimedTodo.API.Services;
using TimedTodo.API.Validation;
using TimedTodo.Data;

namespace TimedTodo.API
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers().AddFluentValidation(fv => 
      fv.RegisterValidatorsFromAssemblyContaining<TaskDefinitionForCreationDtoValidator>());

      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

      services.AddScoped<ITimedTodoRepository, TimedTodoRepository>();

      services.AddDbContext<TimedTodoContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("TimedTodoConnection"))
               .EnableSensitiveDataLogging()
      );
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
