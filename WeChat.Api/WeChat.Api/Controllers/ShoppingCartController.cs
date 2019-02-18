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
        /// 汽车修改状态至已付款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("UpdateBusPaid")]
        public int UpdateBusPaid(int id)
        {
            var i = this.BusTicketRepository.UpdateBusPaid(id);
            return i;
        }

        /// <summary>
        /// 汽车修改状态至退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("UpdateBusNonPaymen")]
        public int UpdateBusNonPaymen(int id)
        {
            var i = this.BusTicketRepository.UpdateBusNonPaymen(id);
            return i;
        }

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
            var planeOrder = this.PlaneTicketRepository.GetPaid();
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
        /// 修改状态至已付款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("UpdateOrderState")]
        public int UpdateOrderState(int id)
        {
            var i = this.PlaneTicketRepository.UpdatePlaneById(id);
            return i;
        }

        /// <summary>
        /// 修改状态至退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("UpdateOrderStateId")]
        public int UpdateOrderStateId_2(int id)
        {
            var i = this.PlaneTicketRepository.UpdateNonPaymentById(id);
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
            var planeOrder = this.PlaneTicketRepository.GetObligation();
            return planeOrder;
        }

        /// <summary>
        /// 飞机票订单查询
        /// </summary>
        /// <returns>退款</returns>
        [HttpGet]
        [ActionName("GetNonPayment")]
        public List<PlaneOrder> GetNonPayment()
        {
            var planeOrder = this.PlaneTicketRepository.GetNonPayment();
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
            var trainTicketInfo = this.TrainTicketRepository.GetPaid();
            return trainTicketInfo;
        }

        /// <summary>
        /// 火车票待付款
        /// </summary>
        /// <returns>返回状态为1</returns>
        [HttpGet]
        [ActionName("GetObligationTrain")]
        public List<TrainTicketOrders> GetObligationTrain()
        {
            var trainTicketInfo = this.TrainTicketRepository.GetObligation();
            return trainTicketInfo;
        }

        /// <summary>
        /// 火车票退款
        /// </summary>
        /// <returns>返回状态 为2</returns>
        [HttpGet]
        [ActionName("GetNonPaymentTrain")]
        public List<TrainTicketOrders> GetNonPaymentTrain()
        {
            var trainTicketInfo = this.TrainTicketRepository.GetNonPayment();
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
            int i = this.TrainTicketRepository.Delete(id);
            return i;
        }

        /// <summary>
        /// 火车票修改状态到退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("UpdateTrainId")]
        public int UpdateTrainId(int id)
        {
            int i = this.TrainTicketRepository.UpdateNonPaymentById(id);
            return i;
        }

        /// <summary>
        /// 火车票修改状态至已支付
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("UpdatePaidById")]
        public int UpdateId(int id)
        {
            int i = this.TrainTicketRepository.UpdatePaidById(id);
            return i;
        }

    }
}