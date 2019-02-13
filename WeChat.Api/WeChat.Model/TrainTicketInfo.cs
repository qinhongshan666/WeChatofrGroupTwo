namespace WeChat.Model
{
    /// <summary>
    /// 火车票信息表
    /// </summary>
    public class TrainTicketInfo
    {
        /// <summary>
        /// 火车票信息表主键ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        public string TrainNumber { get; set; }

        /// <summary>
        /// 火车类型
        /// </summary>
        public string TrainTypes { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        public string BeginTime { get; set; }

        /// <summary>
        /// 出发地点
        /// </summary>
        public string BeginSite { get; set; }

        /// <summary>
        /// 到站时间
        /// </summary>
        public string ArriveTime { get; set; }

        /// <summary>
        /// 到站地点
        /// </summary>
        public string ArriveSite { get; set; }

        /// <summary>
        /// 座位等级
        /// </summary>
        public string SeatGrade { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 余票
        /// </summary>
        public string SurplusTicket { get; set; }

        public int Number { get; set; }

        public int States { get; set; }
    }
}