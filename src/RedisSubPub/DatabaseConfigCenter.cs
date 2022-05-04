using System;
using System.Collections.Generic;
using System.Text;

namespace RedisSubPub
{
   public class DatabaseConfigCenter
    {
        public void ChangeDatabase(string databaseEnviroment)
        {
            Console.WriteLine($"start change database evniroment to {databaseEnviroment}");
            RedisSubPubCenter pubSubCenter = new RedisSubPubCenter();
            pubSubCenter.Publish("database", databaseEnviroment);
            Console.WriteLine($"change database finished:{databaseEnviroment}");
        }
    }

}
