using System;

namespace HostedService_CronJob.CronJobs
{
    public class CronJobConfig<T> : ICronJobConfig<T>
    {
        public string CronExpression { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
    }
}
