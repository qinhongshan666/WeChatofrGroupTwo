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
    public class PlaneTicketRepository : IPlaneTicketRepository
    {
        private string connStr = ConfigHelper.GetConfigValue("sqlConnectionString");

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePlaneById(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "delete from planeorder where ID = " + id;
                var i = con.Execute(str);
                return i;
            }
        }

        /// <summary>
        /// 未付款
        /// </summary>
        /// <returns></returns>
        public List<PlaneOrder> GetNonPayment()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from planeorder where OrderState = 2";
                var lists = con.Query<PlaneOrder>(str).ToList();
                return lists;
            }
        }

        /// <summary>
        /// 待付款
        /// </summary>
        /// <returns></returns>
        public List<PlaneOrder> GetObligation()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from planeorder where OrderState = 1";
                var lists = con.Query<PlaneOrder>(str).ToList();
                return lists;
            }
        }

        /// <summary>
        /// 已付款
        /// </summary>
        /// <returns></returns>

        public List<PlaneOrder> GetPaid()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from planeorder where OrderState = 0";
                var lists = con.Query<PlaneOrder>(str).ToList();
                return lists;
            }
        }

        /// <summary>
        /// 修改状态至退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateNonPaymentById(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {

                string str = "update planeorder set OrderState= 2  where id = " + id;
                int i = con.Execute(str);
                return i;
            }
        }

        /// <summary>
        /// 修改状态至已付款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdatePlaneById(int id)
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                
                string str = "update planeorder set OrderState= 0  where id = "+id;
                int i = con.Execute(str);
                return i;
            }
        }
    }
}