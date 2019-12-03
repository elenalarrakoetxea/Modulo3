using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUnitario;

namespace SaluteTo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSaluteToName()
        {
            ConsoleController bf = new ConsoleController();
            string saluteToOk = bf.SaluteTo("Elena");
            Assert.IsTrue(saluteToOk == "Hola Elena",
               "El saludo debería ser: hola Elena");



        }
        [TestMethod]
        public void TestSaluteToEmpty()
        {
            ConsoleController bf = new ConsoleController();
            string saludo = bf.SaluteTo(string.Empty);

            Assert.IsTrue(saludo == "Dime quien eres",
               "El saludo debería ser: Dime quien eres");
        }

    }
}
