using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.Model;
namespace WeChat.IRespository
{
  public  interface IgetUserRepository
    {
        /// <summary>
        /// 获取微信
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        ClientInfo logins(string code);
    }
}
