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

        private static string _redisServiceUrl = string.Empty;

        /// <summary>
        /// Redis服务器地址
        /// </summary>
        public static string RedisServiceUrl
        {
            get
            {
                _redisServiceUrl = GetConfigValue("RedisServiceUrl");
                // _redisServiceUrl = ConfigurationManager.AppSettings["RedisServiceUrl"];
                return _redisServiceUrl;
            }
        }

        private static int _redisServicePortNum = 0;

        /// <summary>
        /// Redis服务器端口号
        /// </summary>
        public static int RedisServicePortNum
        {
            get
            {
                _redisServicePortNum = int.Parse(GetConfigValue("RedisServicePortNum"));
                return _redisServicePortNum;
            }
        }
    }
}