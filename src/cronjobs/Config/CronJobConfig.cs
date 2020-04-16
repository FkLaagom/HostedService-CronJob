using System;

namespace CronJobs
{
    public class CronJobConfig<T> : ICronJobConfig<T>
    {
        public string CronExpression { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
    }
}
