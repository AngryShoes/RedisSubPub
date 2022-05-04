using System;
using System.Collections.Generic;
using System.Text;

namespace RedisSubPubEmail
{
    public class EmailService
    {
        private Dictionary<string, string> emailTemplateDic = new Dictionary<string, string>();
        public EmailService()
        {
            emailTemplateDic.Add("Development", "Hello, This is a Email Template from Development");
            emailTemplateDic.Add("Staging", "Hello, This is a Email Template from Staging");
            emailTemplateDic.Add("Production", "Hello, This is a Email Template from Production");
        }

        public void UpdateDatabase(string databaseEnvironment)
        {
            Console.WriteLine($"Get database enviroment：{databaseEnvironment}");
            string emailTemplate = emailTemplateDic[databaseEnvironment];
            Console.WriteLine($"Email template：{emailTemplate}");
        }
    }
}
