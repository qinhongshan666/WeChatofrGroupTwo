using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WeChat.Common;
using WeChat.IRespository;
using WeChat.Model;

namespace WeChat.Respository
{
    public class TrainTicketRepository : ITrainTicketRepository
    {
        private string connStr = ConfigHelper.GetConfigValue("sqlConnectionString");


        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "delete from  trainticketorders   where ID =" + id;
                var i = con.Execute(str);
                return i;
            }
        }

        /// <summary>
        /// 退款
        /// </summary>
        /// <returns></returns>
        public List<TrainTicketOrders> GetNonPayment()

        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from trainticketorders where OrdersState = 2";
                var lists = con.Query<TrainTicketOrders>(str).ToList();
                return lists;
            }
        }

        /// <summary>
        /// 待支付
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<TrainTicketOrders> GetObligation()
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string str = "select * from trainticketorders where OrdersState = 1";
                var lists = conn.Query<TrainTicketOrders>(str).ToList();
                return lists;
            }
        }

        /// <summary>
        /// 已支付
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public List<TrainTicketOrders> GetPaid()
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string str = "select * from trainticketorders where OrdersState = 0";
                var lists = conn.Query<TrainTicketOrders>(str).ToList();
                return lists;
            }
        }
        /// <summary>
        /// 修改到退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateNonPaymentById(int id)
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string str = "update  trainticketorders set OrdersState=2 where id = "+id;
                int i = conn.Execute(str);
                return i;
            }
        }
        /// <summary>
        /// 修改到已付款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdatePaidById(int id)
        {
            using (IDbConnection conn = new MySqlConnection(connStr))
            {
                string str = "update  trainticketorders set OrdersState=0 where id = " + id;
                int i = conn.Execute(str);
                return i;
            }
        }
    }
}