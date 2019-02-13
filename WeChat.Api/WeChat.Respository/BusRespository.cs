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
        public int AddBus(BusTicketInfo  busTicketInfo)
        {
            string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string str=string.Format("insert into BusTicketInfo values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", busTicketInfo.StartTime, busTicketInfo.EndTime, busTicketInfo.StartingStation, busTicketInfo.DestinationStation, busTicketInfo.BusPrice, busTicketInfo.Count, busTicketInfo.StartDate);
                return con.Execute(str);
            }
        }

        public BusIndent GetBus(int id)
        {
            string connStr = "Data Source=169.254.240.201;Database=wechat;User ID=root;Pwd=10086";
            using (IDbConnection con = new MySqlConnection(connStr))
            {
                string sql = "select * from Busindent where ID=" + id;
                BusIndent busIndent = con.Query<BusIndent>(sql).FirstOrDefault();

                return busIndent;
            }
        }

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