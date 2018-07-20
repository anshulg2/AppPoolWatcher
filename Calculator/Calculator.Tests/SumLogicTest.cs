using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common;
using Calculator.Controllers;
using Calculator.Data;
using Calculator.Logic;
using Calculator.Logic.Operation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Unity;

namespace Calculator.Tests
{
    [TestClass]
    public class SumLogicTest
    {
        private ILogger _logger;
        private Mock<ISumRepository> _repositoryMock;
        private IOperationFactory _operationFactory;


        [TestInitialize]
        public void Initialize()
        {
            var container = UnityConfig.GetContainer();
            _logger = container.Resolve<ILogger>();
            _repositoryMock = new Mock<ISumRepository>();
            _operationFactory = container.Resolve<IOperationFactory>();
        }

        [TestMethod]
        public void CheckSum()
        {
            SumRequest sum = new SumRequest() { a = 3, b = 4 };

            IOperation sumOperation = new SumOperation(_logger, _repositoryMock.Object);

            _repositoryMock.Setup(x => x.Sum(sum.a, sum.b)).Returns(7);

            var result = (SumResponse)sumOperation.Execute(sum);

            Assert.AreEqual(7, result.Result);
        }
    }
}
