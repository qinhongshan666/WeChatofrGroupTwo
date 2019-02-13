using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.IRespository;
using WeChat.Model;

namespace WeChat.Respository
{
    /// <summary>
    /// 火车票信息类
    /// </summary>
    public class TrainInfoRepository : ITrainInfoRepository
    {
        private string connStr = "Data Source=Jack;Database=wechat;User ID=root;Pwd=199901";

        /// <summary>
        /// 获取所有火车票信息
        /// </summary>
        /// <returns></returns>
        public List<TrainTicketInfo> ShowTrainInfo()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from TrainTicketInfo";
                var ShowTrainInfo = con.Query<TrainTicketInfo>(str).ToList();
                return ShowTrainInfo;
            }
        }

        /// <summary>
        /// 根据ID查询火车票 然后跳转到支付页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TrainTicketInfo Find(int ID)
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string sql = "select * from TrainTicketInfo where ID=" + ID;
                TrainTicketInfo plane = conn.Query<TrainTicketInfo>(sql).FirstOrDefault();
                return plane;
            }
        }

        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int TrainOrderInfo(TrainTicketOrders m)
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string sql = string.Format("insert into TrainTicketOrders values(ID,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", m.TrainNumber, m.BeginTime, m.BeginSite, m.ArriveTime, m.ArriveSite, m.SeatGrade, m.Price, m.SumMoney, m.Iphone, m.UserID, m.OrdersState);
                int result = conn.Execute(sql);
                return result;
            }
        }
    }
}