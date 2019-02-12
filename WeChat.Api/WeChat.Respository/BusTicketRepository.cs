﻿using Dapper;
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
        /// 获取已经实现的汽车票订单
        /// </summary>
        /// <returns></returns>
        public List<BusIndent> BusIndents()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from busindent where OrderState = 1";
                return con.Query<BusIndent>(str).ToList();
            }
        }

        /// <summary>
        /// 获取订单状态为待付款的订单信息
        /// </summary>
        /// <returns></returns>
        public List<BusIndent> GetBusIndentsByState()
        {
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from busindent where OrderState = 2";
                return con.Query<BusIndent>(str).ToList();
            }
        }
    }
}