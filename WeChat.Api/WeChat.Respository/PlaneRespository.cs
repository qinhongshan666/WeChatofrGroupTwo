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
        /// 根据id查询机票
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Plane GetPlane(int id)
        {
            using (IDbConnection conn = new MySqlConnection(connection))
            {
                string sql = "select * from Plane where ID=" + id;
                Plane plane = conn.Query<Plane>(sql).FirstOrDefault();

                return plane;
            }
        }

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
