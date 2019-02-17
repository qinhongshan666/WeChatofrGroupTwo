using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WeChat.IRespository;
using WeChat.Model;

namespace WeChat.Api.Controllers
{
    public class BusController : ApiController
    {
        public IBusRespository ibusrespostitory { get; set; }

        //显示车票的时间日期
        [HttpGet]
        public List<BusIndent> ShowBus(string leavecity, string arrivecity)
        {
            List<BusIndent> busIndents = this.ibusrespostitory.ShowBus().ToList();

            busIndents = busIndents.Where(m => !string.IsNullOrEmpty(leavecity) ? m.StartingStation.Equals(leavecity) : true).Where(m => !string.IsNullOrEmpty(arrivecity) ? m.DestinationStation.Equals(arrivecity) : true).ToList();
            return busIndents;
        }

        //添加汽车票的订单
        [HttpPost]
        [ActionName("addbuss")]
        public int AddBus(BusTicketInfo busTicketInfo)
        {
            int i = ibusrespostitory.AddBus(busTicketInfo);
            return i;
        }

        //获取所有汽车票的信息
        [HttpGet]
        public BusIndent GetBus(int id)
        {
            var busIndent = ibusrespostitory.GetBus(id);
            return busIndent;
        }

        /// <summary>
        /// 获取未付款的车票信息
        /// </summary>
        /// <param name="busIndent"></param>
        /// <returns></returns>
        [HttpPost]
        public int GetBusInfo(BusIndent busIndent)
        {
            int i = ibusrespostitory.GetBusInfo(busIndent);
            return i;
        }
    }
}