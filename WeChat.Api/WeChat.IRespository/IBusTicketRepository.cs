using System.Collections.Generic;

using WeChat.Model;

namespace WeChat.IRespository
{
    public interface IBusTicketRepository
    {
        /// <summary>
        /// 汽车订单查询
        /// </summary>
        /// <returns></returns>
        List<BusTicketInfo> BusIndents();

        List<BusTicketInfo> GetBusIndents();

        List<BusTicketInfo> GetBusIndentsByState();

        /// <summary>
        /// 订单删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteBusById(int id);

        /// <summary>
        /// 修改订单至退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UpdateBusNonPaymen(int id);

        /// <summary>
        /// 修改订单至付款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UpdateBusPaid(int id);
    }
}