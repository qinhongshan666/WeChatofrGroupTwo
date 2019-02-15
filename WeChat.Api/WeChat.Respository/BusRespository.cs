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
    public class BusRespository : IBusRespository
    {

        private string connection = ConfigHelper.GetConfigValue("sqlConnectionString");
        /// <summary>
        /// 添加购票订单信息
        /// </summary>
        /// <param name="busTicketInfo"></param>
        /// <returns></returns>
        public int AddBus(BusTicketInfo busTicketInfo)
        {
            using (IDbConnection con = new MySqlConnection(connection))
            {   
                string str = string.Format("insert into BusTicketInfo values(null,'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}','{7}','{8}','{9}','{10}')", busTicketInfo.StartDate, busTicketInfo.StartTime, busTicketInfo.EndTime, busTicketInfo.StartingStation, busTicketInfo.DestinationStation, busTicketInfo.BusPrice, busTicketInfo.Count, busTicketInfo.OrderState,busTicketInfo.Name,busTicketInfo.Phone,busTicketInfo.IDnumber);
                int i = con.Execute(str);
                return i;
            }
        }

        /// <summary>
        /// 根据ID获取所有的汽车票的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BusIndent GetBus(int id)
        {
            using (IDbConnection con = new MySqlConnection(connection))
            {
                string sql = "select * from Busindent where ID=" + id;
                var busIndent = con.Query<BusIndent>(sql).FirstOrDefault();
                return busIndent;
            }
        }

        /// <summary>
        /// 显示车票信息
        /// </summary>
        /// <returns></returns>
        public List<BusIndent> ShowBus()
        {
            using (IDbConnection con = new MySqlConnection(connection))
            {
                string str = "select * from busindent";
                List<BusIndent> busIndents = con.Query<BusIndent>(str).ToList();
                return busIndents;
            }
        }


    }
}