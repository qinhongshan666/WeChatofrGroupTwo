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
        BusRespository respository = new BusRespository();

        [HttpGet]
        public List<BusIndent> ShowBus( string leavecity,string arrivecity)
        {
            var busmessage = respository.ShowBus();

            busmessage = busmessage.Where(m => !string.IsNullOrEmpty(leavecity) ? m.StartingStation.Equals(leavecity) : true).Where(m => !string.IsNullOrEmpty(arrivecity) ? m.DestinationStation.Equals(arrivecity):true).ToList();
            return busmessage;
        }
    }
}
