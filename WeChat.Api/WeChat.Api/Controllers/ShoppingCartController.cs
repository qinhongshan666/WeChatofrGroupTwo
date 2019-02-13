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
        [ActionName("busIndents")]
        public List<BusIndent> BusIndents()
        {         
           var busIndents = BusTicketRepository.BusIndents();
            return busIndents;
        }

        /// <summary>
        /// 获取订单为待付款状态的汽车票订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("getBusIndents")]
        public List<BusIndent> GetBusIndents()
        {
            var busIndent = BusTicketRepository.GetBusIndentsByState();
            return busIndent;
        }
    }
}