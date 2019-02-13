using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.IRespository;
using WeChat.Model;
using Dapper;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace WeChat.Respository
{
    public class BusRespository : IBusRespository
    {
        /// <summary>
        /// 显示所有的汽车票信息
        /// </summary>
        /// <returns></returns>
        public List<BusIndent> ShowBus()
        {
            string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from busindent";
                return con.Query<BusIndent>(str).ToList();
            }
        }
    }
}