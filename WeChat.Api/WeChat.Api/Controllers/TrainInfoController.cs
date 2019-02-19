using System.Collections.Generic;
using System.Linq;

namespace WeChat.Api.Controllers
{
    using Model;
    using System.Web.Http;
    using WeChat.IRespository;

    public class TrainInfoController : ApiController
    {
        public ITrainInfoRepository Traininfo { get; set; }

        /// <summary>     
        /// 添加订单信息
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        [HttpPost]
        public int TrainOrderInfo(TrainTicketOrders train)
        {
            int i = Traininfo.TrainOrderInfo(train);
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
        public List<TrainTicketInfo> GetTrainInfo(string BeginSite, string ArriveSite,string Times)
        {
            List<TrainTicketInfo> trainInfos = Traininfo.ShowTrainInfo().ToList();

            trainInfos = trainInfos.Where(m => !string.IsNullOrEmpty(BeginSite) ? m.BeginSite.Equals(BeginSite) : true).Where(m => !string.IsNullOrEmpty(ArriveSite) ? m.ArriveSite.Equals(ArriveSite) : true).Where(m => !string.IsNullOrEmpty(Times) ? m.Times.Equals(Times) : true).ToList();
            return trainInfos;
        }
             
        /// <summary>
        /// 根据ID查询火车票 然后跳转到支付页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public TrainTicketInfo FindTrain(int id)
        {
            return Traininfo.FindTrain(id);
        }
    }
}