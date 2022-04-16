using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaquinaDeCafeTDD
{
    [TestClass]
    public class TestVaso
    {
        [TestMethod]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasospequenos = new Vaso(2, 10);
            bool resultado = vasospequenos.hasVasos(1);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void deberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasospequenos = new Vaso(1, 10);
            bool resultado = vasospequenos.hasVasos(2);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void deberiaRestarCantidadDeVaso()
        {
            Vaso vasospequenos = new Vaso(5, 10);
            vasospequenos.giveVasos(1);
            Assert.AreEqual(4, vasospequenos.getCantidadVasos());
        }
    }
}