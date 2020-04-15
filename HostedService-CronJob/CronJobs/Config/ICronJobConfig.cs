using System;

namespace HostedService_CronJob.CronJobs
{
    public interface ICronJobConfig<T>
    {
        string CronExpression { get; set; }
        TimeZoneInfo TimeZoneInfo { get; set; }
    }

}
