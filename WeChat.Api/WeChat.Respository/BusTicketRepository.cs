using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using WeChat.IRespository;
using WeChat.Model;
using WeChat.Common;
 
namespace WeChat.Respository
{
    public class BusTicketRepository : IBusTicketRepository
    {
        //private string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";
        private string connStr = ConfigHelper.GetConfigValue("sqlConnectionString"); 

        /// <summary>
        /// 获取 已经实现的汽车票订单
        /// </summary>
        /// <returns></returns>
        public List<BusTicketInfo> BusIndents()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from BusTicketInfo where OrderState = 0";
                var busIndents = con.Query<BusTicketInfo>(str).ToList();
                return busIndents;
            }
        }

        /// <summary>
        /// 删 除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteBusById(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "delete from BusTicketInfo where Id = " + id;
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

        public int UpdateBusNonPaymen(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "Update  BusTicketInfo  set OrderState=2 where id = "+id;
                var i = con.Execute(str);
                return i;
            }
        }

        public int UpdateBusPaid(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "Update  BusTicketInfo  set OrderState=0 where id = " + id;
                var i = con.Execute(str);
                return i;
            }
        }
    }
}