using System.Collections.Generic;

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