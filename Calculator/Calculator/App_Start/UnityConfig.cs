using System.Web.Http;
using Calculator.Common;
using Calculator.Data;
using Calculator.Logic;
using Unity;
using Unity.WebApi;

namespace Calculator
{
    public static class UnityConfig
    {
        private static IUnityContainer container;

        public static IUnityContainer GetContainer()
        {
            if(container == null)
                RegisterComponents();

            return container;
        }
        public static void RegisterComponents()
        {
            container = new UnityContainer();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            container.RegisterType<IOperationFactory, OperationFactory>();
            container.RegisterType<ILogger, Logger>();
            container.RegisterType<ISumRepository, SumRepository>();
            container.RegisterType<ISubtractRepository, SubtractRepository>();
        }
    }
}