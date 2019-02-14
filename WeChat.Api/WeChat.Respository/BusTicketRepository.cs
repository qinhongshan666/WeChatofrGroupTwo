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
    public class BusTicketRepository : IBusTicketRepository
    {
        private string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";

        /// <summary>
        /// 获取 已经实现的汽车票订单
        /// </summary>
        /// <returns></returns>
        public List<BusTicketInfo> BusIndents()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from BusTicketInfo where OrderState = 0";
                var BusIndents = con.Query<BusTicketInfo>(str).ToList();
                return BusIndents;
            }
        }

        /// <summary>
        /// 删 除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "delete from BusIndent where Id = " + id;
                var i = con.Execute(str);
                return i;
            }
        }

        /// <summary>
        /// 获取退款票信息
        /// </summary>
        /// <returns></returns>
        public List<BusTicketInfo> GetBusIndents()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from BusTicketInfo where OrderState = 2";
                var GetBusIndents = con.Query<BusTicketInfo>(str).ToList();
                return GetBusIndents;
            }
        }

        /// <summary>
        /// 获取订单状态为待付款的订单信息
        /// </summary>
        /// <returns></returns>
        public List<BusTicketInfo> GetBusIndentsByState()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from BusTicketInfo where OrderState = 1";
                var GetBusIndentsByState = con.Query<BusTicketInfo>(str).ToList();
                return GetBusIndentsByState;
            }
        }
    }
}