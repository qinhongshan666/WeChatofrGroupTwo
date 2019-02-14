namespace WeChat.Common
{
    using System.Configuration;

    public class ConfigHelper
    {
        // 获取配置文件中的内容
        public static string GetConfigValue(string strConfigKey)
        {
            var str = ConfigurationManager.AppSettings[strConfigKey];
            return str;
        }
    }
}