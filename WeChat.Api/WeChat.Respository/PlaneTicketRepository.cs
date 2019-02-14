using System.Collections.Generic;
using WeChat.IRespository;
using WeChat.Model;

using System.Data.SqlClient;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;

namespace WeChat.Respository
{
    public class PlaneTicketRepository : IPlaneTicketRepository
    {
        private string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";

        public int DeleteById(int id)
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
        public List<PlaneOrder> NonPayment()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from planeorder where OrderState = 2";
                var lists =  con.Query<PlaneOrder>(str).ToList();
                return lists;

            }
        }

        /// <summary>
        /// 待付款
        /// </summary>
        /// <returns></returns>
        public List<PlaneOrder> Obligation() 
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

        public List<PlaneOrder> Paid()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from planeorder where OrderState = 0";
                var lists = con.Query<PlaneOrder>(str).ToList();
                return lists;

            }
        }
    }
}
