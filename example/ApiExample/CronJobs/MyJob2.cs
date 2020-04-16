using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CronJobs
{
    public class MyJob2 : CronJobBase
    {
        private readonly ILogger<MyJob2> _logger;
        public MyJob2(ICronJobConfig<MyJob2> config, ILogger<MyJob2> logger)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            ApiExample.DataBase.DB.Add($"{DateTime.Now:hh:mm:ss} Job2 working.");
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} Job2 working.");
            return Task.CompletedTask;
        }
    }
}
