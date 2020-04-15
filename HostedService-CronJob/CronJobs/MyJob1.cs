using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HostedService_CronJob.CronJobs
{
    public class MyJob1 : CronJobBase
    {
        private readonly ILogger<MyJob1> _logger;

        public MyJob1(ICronJobConfig<MyJob1> config, ILogger<MyJob1> logger)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("hello job started.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} Job1 working.");
            DataBase.DB.Add($"{DateTime.Now:hh:mm:ss} Hello World! / Job1");
            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("hello job stopped.");
            return base.StopAsync(cancellationToken);
        }
    }
}
