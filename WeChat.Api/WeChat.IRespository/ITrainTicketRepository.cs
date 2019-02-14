using System.Collections.Generic;

using WeChat.Model;

namespace WeChat.IRespository
{
    /// <summary>
    /// 火车信息接口
    /// </summary>
    public interface ITrainTicketRepository
    {
        List<TrainTicketInfo> Paid();

        List<TrainTicketInfo> Obligation();

        List<TrainTicketInfo> NonPayment();

        int DeleteTrainById(int id);
    }
}