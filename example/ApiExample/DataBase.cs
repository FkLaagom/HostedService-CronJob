using System.Collections.Generic;

namespace ApiExample
{
    public static class DataBase
    {
        public static List<string> DB;
        static DataBase()
        {
            DB = new List<string>();
            DB.Add("HELLO");
        }
    }
}
