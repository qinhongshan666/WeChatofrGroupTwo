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
        List<Plane> GetPlanes();
    }
}
