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

using System.Linq;

namespace WeChat.Respository
{
    public class TrainTicketRepository : ITrainTicketRepository
    {
        private string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";
        /// <summary>
        /// 退款
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
        /// </summary>
        /// <returns></returns>
        public List<TrainTicketInfo> Obligation()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from TrainTicketInfo where States = 1";
                var lists = con.Query<TrainTicketInfo>(str).ToList();
                return lists;

            }
        }

        /// <summary>
        /// 已支付
        /// </summary>
        /// <returns></returns>
        public List<TrainTicketInfo> Paid()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from TrainTicketInfo where States = 0";
                var lists = con.Query<TrainTicketInfo>(str).ToList();
                return lists;

            }
        }
    }
}
