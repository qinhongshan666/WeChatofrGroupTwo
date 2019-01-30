using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Model
{
    public class PlaneModels
    {
        public int ID { get; set; }
        public decimal UnitPrice { get; set; }//单价
        public string LeaveCity { get; set; }//出发城市
        public string ArriveCity { get; set; }//到大城市
        public DateTime LeaveDate { get; set; }//出发日期
        public int TypeID { get; set; }//机型ID
        public int Inventory { get; set; }//库存
        public DateTime LeaveTime { get; set; }//出发时间
        public DateTime ArriveTime { get; set; }//到达时间
    }
}
