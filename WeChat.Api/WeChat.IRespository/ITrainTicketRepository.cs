using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.Model;

namespace WeChat.IRespository
{
    /// <summary>
    /// 火车信息接口
    /// </summary>
    public interface ITrainTicketRepository
    {
        /// <summary>
        /// 获取已支付订单
        /// </summary>
        /// <returns></returns>
        List<TrainTicketOrders> GetPaid();

        /// <summary>
        /// 获取待付款订单
        /// </summary>
        /// <returns></returns>
        List<TrainTicketOrders> GetObligation();

        /// <summary>
        /// 获取退款订单
        /// </summary>
        /// <returns></returns>
        List<TrainTicketOrders> GetNonPayment();

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);

        /// <summary>
        /// 修改状态至退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       int UpdateNonPaymentById(int id);

        /// <summary>
        /// 修改状态至已付款
        /// </summary>
        int UpdatePaidById(int id);

    }
}
