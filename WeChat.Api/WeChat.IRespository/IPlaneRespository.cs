using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeChat.IRespository
{
    using Model;
    public interface IPlaneRespository
    {
        //机票
        List<Plane> GetPlanes();
        Plane GetPlane(int id);

        //订单
        int AddPlaneOrder(PlaneOrder planeOrder);
    }
}
