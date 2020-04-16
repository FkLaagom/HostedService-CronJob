using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CronJobs
{
    public class MyJob1 : CronJobBase
    {
        private readonly ILogger<MyJob1> _logger;
        public MyJob1(ICronJobConfig<MyJob1> config, ILogger<MyJob1> logger)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} Job2 working.");
            return Task.CompletedTask;
        }
    }
}
