using CronJobs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ApiExample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCronJob<MyJob1>(x =>
            {
                x.TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
                x.CronExpression = @"*/5 * * * * *"; // Every 5 seconds
            });
            services.AddCronJob<MyJob2>(x =>
            {
                x.TimeZoneInfo = TimeZoneInfo.Local;
                x.CronExpression = @"*/2 * * * * *"; // Every 2 seconds
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
