using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WeChat.IRespository;
using WeChat.Model;
using WeChat.Respository;


namespace WeChat.Api.Controllers
{
    public class BusController : ApiController
    {
        public IBusRespository ibusrespostitory { get; set; }

        [HttpGet]
        public List<BusIndent> ShowBus( string leavecity,string arrivecity)
        {
            List<BusIndent> busIndents = this.ibusrespostitory.ShowBus().ToList();

            busIndents = busIndents.Where(m => !string.IsNullOrEmpty(leavecity) ? m.StartingStation.Equals(leavecity) : true).Where(m => !string.IsNullOrEmpty(arrivecity) ? m.DestinationStation.Equals(arrivecity):true).ToList();
            return busIndents;
        }
        [HttpPost]
        public int AddBus(BusTicketInfo busTicketInfo)
        {
            int i= ibusrespostitory.AddBus(busTicketInfo);
            return i;
        }

        [HttpGet]
        public BusIndent GetBus(int id)
        {
            BusIndent busIndent= ibusrespostitory.GetBus(id);
            return busIndent;
        }
    }
}
