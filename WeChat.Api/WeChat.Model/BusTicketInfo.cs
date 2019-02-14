using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Model
{
    public class BusTicketInfo
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 到达时间
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
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal BusPrice { get; set; }


        public string OrderState { get; set; }
    }
}
