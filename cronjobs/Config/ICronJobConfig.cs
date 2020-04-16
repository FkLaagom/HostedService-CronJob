using System;

namespace CronJobs
{
    public interface ICronJobConfig<T>
    {
        string CronExpression { get; set; }
        TimeZoneInfo TimeZoneInfo { get; set; }
    }

}
