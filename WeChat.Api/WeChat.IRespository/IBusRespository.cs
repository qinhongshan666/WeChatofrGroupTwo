using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Model;

namespace WeChat.IRespository
{
    public interface IBusRespository
    {
        /// <summary>
        /// 显示车票信息
        /// </summary>
        /// <returns></returns>
        List<BusIndent> ShowBus();

        /// <summary>
        /// 根据ID获取所有的汽车票的信息 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BusIndent GetBus(int id);

        /// <summary>
        /// 添加购票订单信息
        /// </summary>
        /// <param name="busTicketInfo"></param>
        /// <returns></returns>
        int AddBus(BusTicketInfo busTicketInfo);
    }
}
