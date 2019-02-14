using System;
using System.Collections.Generic;
using System.Linq;

namespace WeChat.Respository
{
    using Dapper;
    using IRespository;
    using MySql.Data.MySqlClient;
    using System.Data;
    using WeChat.Model;
    using WeChat.Common;

    public class PlaneRespository : IPlaneRespository
    {
        private string connection = ConfigHelper.GetConfigValue("sqlConnectionString");

        /// <summary>
        /// 添加到订单
        /// </summary>
        /// <param name="planeOrder">订单</param>
        /// <returns></returns>
        public int AddPlaneOrder(PlaneOrder planeOrder)
        {
            using (IDbConnection conn = new MySqlConnection(connection))
            {
                string sql = string.Format("INSERT into planeorder VALUES(ID,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", planeOrder.OrderUnitPrice, planeOrder.OrderLeaveCity, planeOrder.OrderArriveCity, planeOrder.OrderLeaveDate, planeOrder.OrderTypeID, planeOrder.OrderTicket, planeOrder.OrderLeaveTime, planeOrder.OrderArriveTime, planeOrder.OrderPhone, planeOrder.OrderState, planeOrder.OrderTotalsum, planeOrder.AccountName);
                int result = conn.Execute(sql);
                return result;
            }
        }

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
        /// 获取机票的订单信息
        /// </summary>
        /// <returns></returns>
        public List<PlaneOrder> GetPlaneOrders()
        {
            throw new NotImplementedException();
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
                var planes = conn.Query<Plane>(sql).ToList();
                return planes;
            }
        }
    }
}