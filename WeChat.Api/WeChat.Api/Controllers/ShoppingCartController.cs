namespace WeChat.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using WeChat.IRespository;
    using WeChat.Model;
    using WeChat.Respository;

    public class ShoppingCartController : ApiController
    {
        public IBusTicketRepository BusTicketRepository { get; set; }

        [HttpGet]
        public List<BusIndent> BusIndents()
        {
           var busIndents = this.BusTicketRepository.BusIndents();
            return busIndents;
        }
    }
}
