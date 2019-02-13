using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Model
{
    /// <summary>
    /// 火车票订单表
    /// </summary>
    public class TrainTicketOrders
    {
        /// <summary>
        /// 火车票订单表Id主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        public int TrainNumber { get; set; }

        /// <summary>
        /// 出发
        /// </summary>
        public int BeginTime { get; set; }

        /// <summary>
        /// 出发地点
        /// </summary>
        public int BeginSite { get; set; }

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
        /// 总金额
        /// </summary>
        public string SumMoney { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Iphone { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public string OrdersState { get; set; }






    }
}
