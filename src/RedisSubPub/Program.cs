using System;

namespace RedisSubPub
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviroment = GetEnvString("environmentVariables:App_Env");
            DatabaseConfigCenter databaseConfigCenter = new DatabaseConfigCenter();
            databaseConfigCenter.ChangeDatabase(enviroment);
            Console.ReadKey();
        }

        private static string GetEnvString(string key)
        {
            var enviroment = ConfigurationHelper.GetConfigString(key);
            return enviroment;
        }
    }
}
