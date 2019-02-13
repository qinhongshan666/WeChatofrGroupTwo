using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Api.Controllers
{
    using Model;
    using WeChat.Respository;

    public class TrainInfoController : Controller
    {
        private TrainInfoRepository traininfo = new TrainInfoRepository();

        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public int TrainOrderInfo(TrainTicketOrders trainTicketOrders)
        {
            int i = traininfo.TrainOrderInfo(trainTicketOrders);
            return i;
        }

        /// <summary>
        /// 根据ID查询火车票 然后跳转到支付页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TrainTicketInfo Find(int ID)
        {
            return traininfo.Find(ID);
        }
    }
}