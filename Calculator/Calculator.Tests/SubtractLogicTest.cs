using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Common;
using Calculator.Data;
using Calculator.Logic;
using Calculator.Logic.Operation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Unity;

namespace Calculator.Tests
{
    
    [TestClass]
    public class SubtractLogicTest
    {
        private ILogger _logger;
        private Mock<ISubtractRepository> _repositoryMock;
        private IOperationFactory _operationFactory;


        [TestInitialize]
        public void Initialize()
        {
            var container = UnityConfig.GetContainer();
            _logger = container.Resolve<ILogger>();
            _repositoryMock = new Mock<ISubtractRepository>();
            _operationFactory = container.Resolve<IOperationFactory>();
        }

        [TestMethod]
        public void CheckSubtract()
        {
            SubtractRequest subtractRequest = new SubtractRequest(){a = 10, b=7};
            _repositoryMock.Setup(x => x.Subtract(subtractRequest.a, subtractRequest.b)).Returns(3);

            IOperation subtractOperation = new SubtractOperation(_logger, _repositoryMock.Object);

            var result = (SubtractResponse)subtractOperation.Execute(subtractRequest);

            Assert.AreEqual(3, result.Result);
        }
    }
}
