namespace WeChat.Api.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using WeChat.IRespository;
    using WeChat.Model;
    using WebApiTokendemo;

    public class PlaneController : ApiController
    {
        public IPlaneRespository PlaneRespository { get; set; }

        /// <summary>
        /// 添加到订单
        /// </summary>
        /// <param name="planeOrder">订单表</param>
        /// <returns>受影响行数</returns>
        [RequestAuthorize]
        [HttpPost]
        public int AddPlaneOrder(PlaneOrder planeOrder)
        {
            int i = this.PlaneRespository.AddPlaneOrder(planeOrder);
            return i;
        }

        /// <summary>
        /// 根据条件查票
        /// </summary>
        /// <param name="leaveCity"></param>
        /// <param name="arriveCity"></param>
        /// <param name="dateDay"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Plane> GetPlanes(string leaveCity, string arriveCity, string dateDay)
        {
            List<Plane> planes = this.PlaneRespository.GetPlanes().ToList();

            planes = planes.Where(m => !string.IsNullOrEmpty(leaveCity) ? m.LeaveCity.Equals(leaveCity) : true).Where(m => !string.IsNullOrEmpty(arriveCity) ? m.ArriveCity.Equals(arriveCity) : true).Where(m => !string.IsNullOrEmpty(dateDay) ? m.LeaveDate.Equals(dateDay) : true).ToList();

            return planes;
        }

        /// <summary>
        /// 根据id查询并反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Plane GetPlane(int id)
        {
            var plane = this.PlaneRespository.GetPlane(id);
            return plane;
        }
    }
}