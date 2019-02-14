namespace WeChat.Model
{
    public class Account
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string AccountPwd { get; set; }

        /// <summary>
        /// 预留手机号
        /// </summary>
        public string AccountPhone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string AccountEmail { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string AccountCard { get; set; }
    }
}