using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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