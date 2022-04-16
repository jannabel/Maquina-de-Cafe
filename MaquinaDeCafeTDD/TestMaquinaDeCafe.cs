using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaquinaDeCafeTDD
{
    [TestClass]
    public class TestMaquinaDeCafe
    {
        Cafetera cafetera;
        Vaso vasosPequenos;
        Vaso vasosMedianos;
        Vaso vasosGrandes;
        Azucarero azucarero;
        MaquinadeCafe maquinadeCafe;

        [TestInitialize]
        public void SetUp()
        {
            cafetera = new Cafetera(50);
            vasosPequenos = new Vaso(5, 10);
            vasosMedianos = new Vaso(5, 20);
            vasosGrandes = new Vaso(5, 30);
            azucarero = new Azucarero(20);
            maquinadeCafe = new MaquinadeCafe();
            maquinadeCafe.setCafetera(cafetera);
            maquinadeCafe.setVasosPequeno(vasosPequenos);
            maquinadeCafe.setvasosMediano(vasosMedianos);
            maquinadeCafe.setvasosGrandes(vasosGrandes);
            maquinadeCafe.setAzucarero(azucarero);
        }

        [TestMethod]
        public void deberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            Assert.AreEqual(maquinadeCafe.vasosPequenos, vaso);
        }

        [TestMethod]
        public void deberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("mediano");
            Assert.AreEqual(maquinadeCafe.vasosMedianos, vaso);
        }

        [TestMethod]
        public void deberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("grande");
            Assert.AreEqual(maquinadeCafe.vasosGrandes, vaso);
        }

        [TestMethod]
        public void deberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            string resultado = maquinadeCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", resultado);
        }

        [TestMethod]
        public void deberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinadeCafe.setCafetera(cafetera);
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            string resultado = maquinadeCafe.getVasoDeCafe(vaso, 1, 2);
            Assert.AreEqual("No hay Cafe", resultado);
        }

        [TestMethod]
        public void deberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinadeCafe.setAzucarero(azucarero);
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            string resultado = maquinadeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay Azucar", resultado);
        }

        [TestMethod]
        public void deberiaRestarCafe()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            maquinadeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinadeCafe.getCafetera().getCantidadDeCafe();
            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void deberiaRestarVaso()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            maquinadeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinadeCafe.getVasosPequeno().getCantidadVasos();
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void deberiaRestarAzucar()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            maquinadeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinadeCafe.getAzucarero().getCantidadDeAzucar();
            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void deberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinadeCafe.getTipoVaso("pequeno");
            string resultado = maquinadeCafe.getVasoDeCafe(vaso,1,3);
            Assert.AreEqual("Felicitaciones", resultado);
        }
    }
}
