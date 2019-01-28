using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace WeChat.Respository
{
    using System.Data;
    using WeChat.IRespository;
    using WeChat.Model;

    public class Planedll : IPlanedll
    {
        private string connection = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";
        /// <summary>
        /// 查询所有机票
        /// </summary>
        /// <returns></returns>
        public List<PlaneModels> PlaneIndex()
        {
            using (IDbConnection conn = new MySqlConnection(connection))
            {
                string sql = "select * from Plane";
                var planeModels = conn.Query<PlaneModels>(sql).ToList();
                return planeModels;
            }
        }
    }
}
