using System;

namespace RedisSubPubTextMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text message service start subsribe database change...");
            RedisSubPubCenter redisSubPubCenter = new RedisSubPubCenter();
            redisSubPubCenter.Subscribe("database", message =>
            {
                string databaseEnviroment = message.Message;
                TextMessageService textMessageService  = new TextMessageService();
                textMessageService.UpdateDatabase(databaseEnviroment);
            });
            Console.ReadKey();
        }
    }
}
