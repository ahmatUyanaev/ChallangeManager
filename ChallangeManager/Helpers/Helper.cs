using System.Configuration;

namespace ChallangeManager.Helpers
{
    public static class Helper
    {
        public static string GetConValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
