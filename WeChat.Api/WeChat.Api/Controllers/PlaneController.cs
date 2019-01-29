using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WeChat.Api.Controllers
{
    using Model;
    using Respository;
    public class PlaneController : ApiController
    {
        PlaneRespository planeRespository = new PlaneRespository();
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
            List<Plane> planes = planeRespository.GetPlanes().ToList();

            planes = planes.Where(m => !string.IsNullOrEmpty(leaveCity) ? m.LeaveCity.Equals(leaveCity) : true).Where(m => !string.IsNullOrEmpty(arriveCity) ? m.ArriveCity.Equals(arriveCity) : true).Where(m => !string.IsNullOrEmpty(dateDay) ? m.LeaveDate.Equals(dateDay) : true).ToList();

            return planes;
        }
    }
}
