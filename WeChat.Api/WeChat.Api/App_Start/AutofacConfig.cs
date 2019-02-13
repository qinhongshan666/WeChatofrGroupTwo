using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using WeChat.IRespository;
using WeChat.Respository;

namespace WebApplicationAutofac
{
    public static class AutofacConfig
    {
        /// <summary>
        /// 项目初始化，实例化IOC容器
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);

            // 注册所有的ApiControllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();

            // 注册api容器需要使用HttpConfiguration对象
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 将实现类与接口注入到IOC容器中
        /// </summary>
        /// <param name="builder">builder</param>
        public static void SetupResolveRules(ContainerBuilder container)
        {
            container.RegisterType<BusRespository>().As<IBusRespository>();
            container.RegisterType<BusTicketRepository>().As<IBusTicketRepository>();
            container.RegisterType<PlaneTicketRepository>().As<IPlaneTicketRepository>();
            container.RegisterType<TrainTicketRepository>().As<ITrainTicketRepository>();
        }
    }
}