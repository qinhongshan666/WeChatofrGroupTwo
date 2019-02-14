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
        List<TrainTicketOrders> Paid();

        List<TrainTicketOrders> Obligation();

        List<TrainTicketOrders> NonPayment();

        int Delete(int id);

    }
}
