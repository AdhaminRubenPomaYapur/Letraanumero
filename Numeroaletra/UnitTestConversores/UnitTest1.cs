using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeroaletra.Controllers;

namespace UnitTestConversores
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConversor(){
            //Arrange
            LiteralController literalController = new LiteralController();
            int a;
            a = 5;
            string esperado = "CINCO PESOS 00 /100";
            //Act
            string resultado = literalController.LiteralGet(a);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
