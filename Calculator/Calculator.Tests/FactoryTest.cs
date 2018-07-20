using System;
using Calculator.Data;
using Calculator.Logic;
using Calculator.Common;
using Calculator;
using Calculator.Logic.Operation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace Calculator.Tests
{
    [TestClass]
    public class FactoryTest
    {
        private ILogger _logger;
        private ISumRepository _sumRepository;
        private ISubtractRepository _subtractRepository;

        [TestInitialize]
        public void Initialize()
        {
            var container = UnityConfig.GetContainer();
            _logger = container.Resolve<ILogger>();
            _sumRepository = container.Resolve<ISumRepository>();
            _subtractRepository = container.Resolve<ISubtractRepository>();
        }

        [TestMethod]
        public void TestMethod1()
        {
            SumRequest sum = new SumRequest() {a = 3, b = 4};

            IOperationFactory operationFactory = new OperationFactory(_logger, _sumRepository, _subtractRepository);
            var operation = operationFactory.Create(sum);

            Assert.AreEqual(typeof(SumOperation), operation.GetType());

        }
    }
}
