using System;

namespace RedisSubPubEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email service start subsribe database change...");
            RedisSubPubCenter redisSubPubCenter = new RedisSubPubCenter();
            redisSubPubCenter.Subscribe("database", message =>
            {
                string databaseEnviroment = message.Message;
                EmailService emailService = new EmailService();
                emailService.UpdateDatabase(databaseEnviroment);
            });
            Console.ReadKey();
        }
    }
}
