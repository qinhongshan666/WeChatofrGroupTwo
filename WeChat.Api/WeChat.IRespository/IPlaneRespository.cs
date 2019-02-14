using System.Collections.Generic;

namespace WeChat.IRespository
{
    using Model;

    public interface IPlaneRespository
    {
        /// <summary>
        /// 获取机票信息
        /// </summary>
        /// <returns></returns>
        List<Plane> GetPlanes();

        Plane GetPlane(int id);

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="planeOrder"></param>
        /// <returns></returns>
        int AddPlaneOrder(PlaneOrder planeOrder);

        /// <summary>
        /// 获取机票的订单信息 实现点击显示功能
        /// </summary>
        List<PlaneOrder> GetPlaneOrders();
    }
}