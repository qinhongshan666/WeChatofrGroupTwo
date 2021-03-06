﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.Common;
using WeChat.Model;
using WeChat.IRespository;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using System.Net.Http;
using CommonCache;
using Newtonsoft.Json;

namespace WeChat.Respository
{
    public class GetRepository : IgetUserRepository
    {
        public string connstr = ConfigHelper.GetConfigValue("sqlConnectionString");

        public ClientInfo logins(string code)
        {
            using (IDbConnection conn = new MySqlConnection(connstr))
            {
                ClientInfo clientInfo = new ClientInfo();
                HttpClient httpClient = new HttpClient();


                string appid = "wx9d811fa9164d692c";
                string secret = "5f5fdec1941960d6a94f6c6282a15441";


                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = httpClient.PostAsync("https://api.weixin.qq.com/sns/jscode2session?appid=" + appid + "&secret=" + secret + "&js_code=" + code.ToString() + "&grant_type=authorization_code", null).Result;
                var result = "";
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                httpClient.Dispose();//释放缓存
                var results = JsonConvert.DeserializeObject<ClientInfo>(result);
                clientInfo.OpenId = results.OpenId;
                clientInfo.Session_key = results.Session_key;
                //根据openid检查用户是否已存在
                var client = getUserByopenid(clientInfo.OpenId);
                if (client.Count == 0)
                {
                    AddUser(clientInfo);
                }
                RedisHelper.Set<ClientInfo>(clientInfo.Session_key, clientInfo, DateTime.Now.AddHours(5));
                return clientInfo;
            }
        }

        //判断用户书否已存在
        public List<ClientInfo> getUserByopenid(string openid)
        {
            using (IDbConnection conn = new MySqlConnection(connstr))
            {
                string sql = $"select * from ClientInfo where OpenId='{openid}'";

                var list = conn.Query<ClientInfo>(sql).ToList();
                return list;
            }
        }

        //对于不存在的用户添加到数据库中
        public int AddUser(ClientInfo clientInfo)
        {
            using (IDbConnection conn = new MySqlConnection(connstr))
            {
                string sql = $"insert into ClientInfo values(null,'{clientInfo.OpenId}','{clientInfo.ClientName}','{clientInfo.Session_key}','{clientInfo.UserName}','{clientInfo.UserPwd}')";

                var i = conn.Execute(sql);
                return i;
            }
        }
    }
}