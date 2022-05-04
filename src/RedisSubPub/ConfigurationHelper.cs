using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RedisSubPub
{
    public class ConfigurationHelper
    {
        public static string GetConfigString(string key)
        {
            var configurationRoot = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json", false, true).Build();
            return configurationRoot[key];
        }
    }
}
