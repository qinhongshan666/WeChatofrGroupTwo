using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WeChat.Model;
using WeChat.IRespository;
using WeChat.Respository;

namespace WeChat.Api.Controllers
{
    public class ShoppingCartController : ApiController
    {
        public IBusTicketRepository BusTicketRepository { get; set; }
        [HttpGet]
        public List<BusIndent> BusIndents()
        {         
           var busIndents = BusTicketRepository.BusIndents();
            return busIndents;
        }
    }
}
