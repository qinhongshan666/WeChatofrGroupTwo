using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.Model;

namespace WeChat.IRespository
{
   public interface ITrainTicketRepository
    {

        List<TrainTicketInfo> Paid();

        List<TrainTicketInfo> Obligation();

        List<TrainTicketInfo> NonPayment();
    }
}
