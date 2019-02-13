namespace WeChat.Api.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using WeChat.IRespository;
    using WeChat.Model;

    public class ShoppingCartController : ApiController
    {
        /// <summary>
        /// 属性注入
        /// </summary>
        public IBusTicketRepository BusTicketRepository { get; set; }

        public IPlaneTicketRepository PlaneTicketRepository { get; set; }

        public ITrainTicketRepository TrainTicketRepository { get; set; }

        /// <summary>
        /// 获取订单状态为已付款的汽车票订 单
        /// </summary>
        /// <returns>已付款returns>
        [HttpGet]
        [ActionName("busIndents")]
        public List<BusTicketInfo> BusIndents()
        {
            var busIndents = this.BusTicketRepository.BusIndents();
            return busIndents;
        }

        /// <summary>
        /// 获取订单为待付款状态的汽车票订 单
        /// </summary>
        /// <returns>待付款</returns>
        [HttpGet]
        [ActionName("getBusIndents")]
        public List<BusTicketInfo> GetBusIndents()
        {
            var busIndent = this.BusTicketRepository.GetBusIndentsByState();
            return busIndent;
        }

        /// <summary>
        /// 汽车票退款
        /// </summary>
        /// <returns>退款中</returns>
        [HttpGet]
        [ActionName("getBusIndent")]
        public List<BusTicketInfo> GetBusIndent()
        {
            var busIndent = this.BusTicketRepository.GetBusIndents();
            return busIndent;
        }

        /// <summary>
        /// 汽车根据Id删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("DeleteById")]
        public int DeleteBusById(int id)
        {
            int i = this.BusTicketRepository.DeleteBusById(id);
            return i;
        }

        /// <summary>
        /// 飞机票订单查询
        /// </summary>
        /// <returns>已付款</returns>
        [HttpGet]
        [ActionName("GetPaid")]
        public List<PlaneOrder> GetPaid()
        {
            var planeOrder = this.PlaneTicketRepository.Paid();
            return planeOrder;
        }

        /// <summary>
        /// 飞机票订单删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        [ActionName("Delete")]
        public int DeletePlaneById(int id)
        {
            var i = this.PlaneTicketRepository.DeletePlaneById(id);
            return i;
        }

        /// <summary>
        /// 飞机票订单查询
        /// </summary>
        /// <returns>待付款</returns>
        [HttpGet]
        [ActionName("GetObligation")]
        public List<PlaneOrder> GetObligation()
        {
            var planeOrder = this.PlaneTicketRepository.Obligation();
            return planeOrder;
        }

        /// <summary>
        /// 飞机票订单查询
        /// </summary>
        /// <returns>未付款</returns>
        [HttpGet]
        [ActionName("GetNonPayment")]
        public List<PlaneOrder> GetNonPayment()
        {
            var planeOrder = this.PlaneTicketRepository.NonPayment();
            return planeOrder;
        }

        /// <summary>
        /// 火车已付款
        /// </summary>
        /// <returns>状态为0</returns>
        [HttpGet]
        [ActionName("GetPaidTrain")]
        public List<TrainTicketOrders> GetPaidTrain()
        {
            var trainTicketInfo = this.TrainTicketRepository.Paid();
            return trainTicketInfo;
        }

        /// <summary>
        /// 待付款
        /// </summary>
        /// <returns>返回状态为1</returns>
        [HttpGet]
        [ActionName("GetObligationTrain")]
        public List<TrainTicketOrders> GetObligationTrain()
        {
            var trainTicketInfo = this.TrainTicketRepository.Obligation();
            return trainTicketInfo;
        }

        /// <summary>
        /// 退款
        /// </summary>
        /// <returns>返回状态 为2</returns>
        [HttpGet]
        [ActionName("GetNonPaymentTrain")]
        public List<TrainTicketOrders> GetNonPaymentTrain()
        {
            var trainTicketInfo = this.TrainTicketRepository.NonPayment();
            return trainTicketInfo;
        }

        /// <summary>
        /// 火车根据Id删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("DeleteTrainId")]
        public int DeleteTrainById(int id)
        {
            int i = this.TrainTicketRepository.DeleteTrainById(id);
            return i;
        }
    }
}