using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApp.Classes;
using WebApp.Controllers;

namespace TestProject
{
    [TestClass]
    public class TestFile
    {
        [TestMethod]
        public void Test_Controller_link()
        {
            var stateMock = new Mock<IState>();
            stateMock.Setup(st => st.switch_on()).Returns(true);
            var controller = new StateController(stateMock.Object);
            Assert.AreEqual(controller.switch_on(), true);
        }
    }
}
