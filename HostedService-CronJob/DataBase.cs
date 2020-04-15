using System.Collections.Generic;

namespace HostedService_CronJob
{
    public static class DataBase
    {
        public static List<string> DB;
        static DataBase()
        {
            DB = new List<string>();
            DB.Add("HELLO");
            DB.Add("HEL2O");
        }
    }
}
