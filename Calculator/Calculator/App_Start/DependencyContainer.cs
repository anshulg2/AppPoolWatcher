using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Calculator.Common;
using Calculator.Logic;
using Unity;

namespace Calculator
{
    public class DependencyContainer
    {
        private static Lazy<IUnityContainer>
            container = new Lazy<IUnityContainer>(() =>
            {
                var container = new UnityContainer();
                RegisterTypes(container);
                return container;
            });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. 
            // Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IOperationFactory, OperationFactory>();
            container.RegisterType<ILogger, Logger>();

        }
    }
}