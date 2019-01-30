using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Model
{
    /// <summary>
    /// 火车票信息表
    /// </summary>
   public class TrainTicketInfo
    {
        //火车票信息表主键ID
        public int ID { get; set; }

        //车次
        public string TrainNumber { get; set; }

        //火车类型
        public string TrainTypes { get; set; }

        //出发时间
        public string BeginTime { get; set; }

        //出发地点
        public string BeginSite { get; set; }

        //到站时间
        public string ArriveTime { get; set; }

        //到站地点
        public string ArriveSite { get; set; }

        //座位等级
        public string SeatGrade { get; set; }

        //价格
        public string Price { get; set; }

        //余票
        public string SurplusTicket { get; set; }
    }
}
