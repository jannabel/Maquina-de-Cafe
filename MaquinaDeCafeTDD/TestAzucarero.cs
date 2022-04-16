using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaquinaDeCafeTDD
{
    [TestClass]
    public class TestAzucarero
    {
        Azucarero azuquero;

        [TestInitialize]
        public void SetUp()
        {
           azuquero = new Azucarero(10);
        }

        [TestMethod]
        public void deberiadevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.hasAzucar(5);
            Assert.IsTrue(resultado);

            resultado = azuquero.hasAzucar(10);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void deberiadevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.hasAzucar(15);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void deberiaRestarAzucarAlAzuquero()
        {
            azuquero.giveAzucar(5);
            Assert.AreEqual(5, azuquero.getCantidadDeAzucar());
            azuquero.giveAzucar(2);
            Assert.AreEqual(3, azuquero.getCantidadDeAzucar());
        }
    }
}
