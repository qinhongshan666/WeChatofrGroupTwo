namespace WeChat.Model
{
    public class PlaneOrder
    {
        public int ID { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal OrderUnitPrice { get; set; }

        /// <summary>
        /// 出发城市
        /// </summary>
        public string OrderLeaveCity { get; set; }

        /// <summary>
        /// 到达城市
        /// </summary>
        public string OrderArriveCity { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        public string OrderLeaveDate { get; set; }

        /// <summary>
        /// 机型
        /// </summary>
        public int OrderTypeID { get; set; }

        /// <summary>
        /// 票数
        /// </summary>
        public int OrderTicket { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        public string OrderLeaveTime { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public string OrderArriveTime { get; set; }

        /// <summary>
        /// 取票手机号
        /// </summary>
        public string OrderPhone { get; set; }

        /// <summary>
        /// 支付状态
        /// </summary>
        public int OrderState { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal OrderTotalsum { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 飞机票ID
        /// </summary>
        public int PlaneID { get; set; }
    }
}