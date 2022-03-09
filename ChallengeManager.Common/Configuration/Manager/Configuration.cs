using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ChallengeManager.Common.Configuration.Manager
{
    public static class Configuration
    {
        //private readonly string _configPath = $@"C:\Users\A-UYANAEV\source\repos\ChallangeManager\ChallengeManager.Common\Configuration\Configs\CommonConfig.config";
        public static string GetDbConnection()
        {
            var cc = ConfigurationManager.AppSettings["dbName"];
            return ConfigurationManager.AppSettings["dbName"];
        }
    }
}
