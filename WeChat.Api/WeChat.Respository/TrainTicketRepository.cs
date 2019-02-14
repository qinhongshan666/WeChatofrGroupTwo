using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WeChat.IRespository;
using WeChat.Model;

namespace WeChat.Respository
{
    public class TrainTicketRepository : ITrainTicketRepository
    {
        private string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";

        public int Delete(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "delete from  TrainTicketInfo   where ID =" + id;
                var i = con.Execute(str);
                return i;
            }
        }


        /// <summary>
        /// 退款
        /// 获取所有火车票信息
        /// </summary>
        /// <returns></returns>
        public List<TrainTicketInfo> NonPayment()

        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from TrainTicketInfo where States = 2";
                var lists = con.Query<TrainTicketInfo>(str).ToList();
                return lists;
            }
        }


        /// <summary>
        /// 待支付
        /// 根据ID查询火车票 然后跳转到支付页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<TrainTicketInfo> Obligation()
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string str = "select * from TrainTicketInfo where States = 1";
                var lists = conn.Query<TrainTicketInfo>(str).ToList();
                return lists;
            }
        }


        /// <summary>
        /// 已支付
        /// 添加订单信息
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public List<TrainTicketInfo> Paid()
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string str = "select * from TrainTicketInfo where States = 0";
                var lists = conn.Query<TrainTicketInfo>(str).ToList();
                return lists;
            }
        }
    }

}

