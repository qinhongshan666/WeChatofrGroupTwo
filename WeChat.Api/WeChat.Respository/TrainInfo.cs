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
    public class TrainInfo : ITrainInfo
    {
        /// <summary>
        /// 获取所有火车票信息
        /// </summary>
        /// <returns></returns>
        public List<TrainTicketInfo> ShowTrainInfo()
        {
            string connStr = "Data Source=Jack;Database=wechat;User ID=root;Pwd=199901";
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str = "select * from TrainTicketInfo";
                return con.Query<TrainTicketInfo>(str).ToList();
            }
        }












    }
}
