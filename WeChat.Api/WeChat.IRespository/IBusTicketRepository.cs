using System.Collections.Generic;

using WeChat.Model;

namespace WeChat.IRespository
{
    public interface IBusTicketRepository
    {
        List<BusTicketInfo> BusIndents();

        List<BusTicketInfo> GetBusIndents();

        List<BusTicketInfo> GetBusIndentsByState();

        int DeleteBusById(int id); 
    }
}