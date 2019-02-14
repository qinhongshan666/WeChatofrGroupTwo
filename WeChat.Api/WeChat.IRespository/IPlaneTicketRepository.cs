using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeChat.Model;

namespace WeChat.IRespository
{
   public interface IPlaneTicketRepository
    {
        List<PlaneOrder> Paid();

        List<PlaneOrder> Obligation();

        List<PlaneOrder> NonPayment();

        int DeletePlaneById(int id);
    }
}
