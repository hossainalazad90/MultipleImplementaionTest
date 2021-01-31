using Autofac;
using Autofac.Integration.Mvc;
using MultipleImplementaionTest.Services.Implementation;
using MultipleImplementaionTest.Services.Interface;
using System.Reflection;
using System.Web.Mvc;

namespace MultipleImplementaionTest.App_Start
{
    public static class AutofacConfig
    {
        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();           
            //builder.RegisterType<IsolatedImplementation>().As<IImplementation<IsolatedImplementation>>();
            builder.RegisterType<SmartERPImplementation>().As<IImplementation<SmartERPImplementation>>();
            builder.RegisterType<OracleERPImplementaion>().As<IImplementation<OracleERPImplementaion>>();


            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}