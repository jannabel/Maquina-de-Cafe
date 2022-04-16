using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaquinaDeCafeTDD
{
    [TestClass]
    public class TestCafetera
    {
        [TestMethod]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(5);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(11);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void deberiaRestarCafeAlaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);
            cafetera.giveCafe(7);
            Assert.AreEqual(3, cafetera.getCantidadDeCafe());
        }

    }

}
