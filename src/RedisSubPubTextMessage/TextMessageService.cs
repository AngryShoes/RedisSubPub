using System;
using System.Collections.Generic;
using System.Text;

namespace RedisSubPubTextMessage
{
    class TextMessageService
    {
        private Dictionary<string, string> textMessageDic = new Dictionary<string, string>();
        public TextMessageService()
        {
            textMessageDic.Add("Development", "Hello, This is a Text Message Template from Development");
            textMessageDic.Add("Staging", "Hello, This is a Text Message Template from Staging");
            textMessageDic.Add("Production", "Hello, This is a Text Message Template from Production");
        }

        public void UpdateDatabase(string databaseEnvironment)
        {
            Console.WriteLine($"Get database enviroment：{databaseEnvironment}");
            string textMessageTemplate = textMessageDic[databaseEnvironment];
            Console.WriteLine($"Text message template：{textMessageTemplate}");
        }
    }
}
