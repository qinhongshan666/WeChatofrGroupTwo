using System.Collections.Generic;
using WeChat.Model;

namespace WeChat.IRespository
{
    /// <summary>
    /// 火车信息接口
    /// </summary>
    public interface ITrainInfoRepository
    {
        /// <summary>
        /// 查询所有票数信息
        /// </summary>
        /// <returns></returns>
        List<TrainTicketInfo> ShowTrainInfo();

        /// <summary>
        /// 根据ID查找火车票信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        TrainTicketInfo FindTrain(int id);

        /// <summary>
        /// 订单信息
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        int TrainOrderInfo(TrainTicketOrders trainTicketOrders);
    }
}