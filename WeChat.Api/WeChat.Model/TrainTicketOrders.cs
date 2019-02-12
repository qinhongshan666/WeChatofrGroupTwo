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
        //火车票订单表Id主键
        public int ID { get; set; }

        //车次
        public int TrainNumber { get; set; }

        //出发
        public int BeginTime { get; set; }

        //出发地点
        public int BeginSite { get; set; }

        //到站时间
        public string ArriveTime { get; set; }

        //到站地点
        public string ArriveSite { get; set; }

        //座位等级
        public string SeatGrade { get; set; }

        //价格
        public string Price { get; set; }

        //总金额
        public string SumMoney { get; set; }

        //手机号
        public string Iphone { get; set; }

        //用户ID
        public string UserID { get; set; }

        //订单状态
        public string OrdersState { get; set; }






    }
}
