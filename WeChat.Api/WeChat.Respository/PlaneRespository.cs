using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.Respository
{
    using IRespository;
    using WeChat.Model;
    using Dapper;
    using MySql.Data.MySqlClient;
    using System.Data;

    public class PlaneRespository : IPlaneRespository
    {
        private string connection = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";
        /// <summary>
        /// 查询所有机票
        /// </summary>
        /// <returns></returns>
        public List<Plane> GetPlanes()
        {
            using (IDbConnection conn = new MySqlConnection(connection))
            {
                string sql = "select * from Plane";
                List<Plane> planes = conn.Query<Plane>(sql).ToList();
                return planes;
            }
        }
    }
}
