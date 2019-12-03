using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUnitario;

namespace TestSaluteToEmpty
{
    [TestClass]
    public class UnitTest1
    {
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
