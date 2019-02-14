using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Model
{
    public class BusIndent
    {
       
        /// <summary>
        /// 汽车主键ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 发车时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 起始站
        /// </summary>
        public string StartingStation { get; set; }

        /// <summary>
        /// 终点站
        /// </summary>
        public string DestinationStation { get; set; }

        /// <summary>
        /// 汽车票类型
        /// </summary>
        public int BusTypeID { get; set; }

        /// <summary>
        /// 汽车票单价
        /// </summary>
        public decimal BusPrice { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string OrderState { get; set; }


        public int Count { get; set; }


    }
}