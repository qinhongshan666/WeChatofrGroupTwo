﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Api.Controllers
{
    using WeChat.IRespository;
    using Model;
    using System.Web.Http;
    using WeChat.Respository;
    public class TrainInfoController : ApiController
    {
       public ITrainInfoRepository Traininfo { get; set; }

        /// <summary>
        /// 添加订单信息
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public int TrainOrderInfo(TrainTicketOrders m)
        {
            int i = Traininfo.TrainOrderInfo(m);
            return i;
        }

        /// <summary>
        /// 根据条件查票
        /// </summary>
        /// <param name="BeginSite">始发地</param>
        /// <param name="ArriveSite">终止站</param>
        /// <param name="BeginTime">出发日期</param>
        /// <returns></returns>
        [HttpGet]
        public List<TrainTicketInfo> GetTrainInfo(string BeginSite, string ArriveSite )
        {
            List<TrainTicketInfo> trainInfos = Traininfo.ShowTrainInfo().ToList();

            trainInfos = trainInfos.Where(m => !string.IsNullOrEmpty(BeginSite) ? m.BeginSite.Equals(BeginSite) : true).Where(m => !string.IsNullOrEmpty(ArriveSite) ? m.ArriveSite.Equals(ArriveSite) : true).ToList();
            return trainInfos;
        }


        /// <summary>
        /// 根据ID查询火车票 然后跳转到支付页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public TrainTicketInfo FindTrain(int ID)
        {
            return Traininfo.FindTrain(ID);
        }




    }
}