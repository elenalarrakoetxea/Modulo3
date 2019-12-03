using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestUnitario;

namespace HellloUT.Test
{
    [TestClass]
    public class UnitTest1
    {
        ConsoleController bf;

        [TestInitialize]
        public void SetUpBF()
        {
            bf = new ConsoleController();
        }
        [TestMethod]
        public void TestMethod1()
        {
           
            string saludo = bf.Salute();

            Assert.IsTrue(saludo == "Hola mundo",
                "El saludo debería ser: hola mundo");
        }
        [TestMethod]
        public void TestSaluteToName()
        {
            
            string saludo = bf.SaluteTo("Elena");
            Assert.IsTrue(saludo == "Hola Elena",
               "El saludo debería ser: hola Elena");

        }
        [TestMethod]
        public void TestSaluteToEmpty()
        {
            
            string saludo = bf.SaluteTo(string.Empty);

            Assert.IsTrue(saludo == "Dime quien eres",
               "El saludo debería ser: Dime quien eres");
        }
        [TestMethod, ExpectedException(typeof(NullReferenceException))]
        public void TestSaluteToNullError()
        {
           
            bf.SaluteTo(null);
            Assert.Fail("Debería haber una excepción");
           

        }

    }
}
