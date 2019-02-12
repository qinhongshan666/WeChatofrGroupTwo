using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Model
{
    public class Plane
    {
        public int ID { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 出发城市
        /// </summary>
        public string LeaveCity { get; set; }

        /// <summary>
        /// 到大城市
        /// </summary>
        public string ArriveCity { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        public string LeaveDate { get; set; }

        /// <summary>
        /// 机型ID
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public int Inventory { get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        public string LeaveTime { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public string ArriveTime { get; set; }
    }
}
