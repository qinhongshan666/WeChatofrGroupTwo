using System.Collections.Generic;

using WeChat.Model;

namespace WeChat.IRespository
{
    public interface IPlaneTicketRepository
    {
        /// <summary>
        /// 获取已支付订单
        /// </summary>
        /// <returns></returns>
        List<PlaneOrder> GetPaid();

        /// <summary>
        /// 获取待支付订单
        /// </summary>
        /// <returns></returns>
        List<PlaneOrder> GetObligation();

        /// <summary>
        /// 获取未支付订单
        /// </summary>
        /// <returns></returns>
        List<PlaneOrder> GetNonPayment();

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeletePlaneById(int id);

        /// <summary>
        /// 修改订单至已付款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UpdatePlaneById(int id);

        /// <summary>
        /// 修改状态至退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UpdateNonPaymentById(int id);
    }
}