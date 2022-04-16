namespace MaquinaDeCafeTDD
{
    internal class Vaso
    {
        int cantidadVasos { get; set; }
        int contenido { get; set; }

        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
        }

        public void setCantidadVasos(int param1) { cantidadVasos = param1; }

        public int getCantidadVasos() { return cantidadVasos; }

        public void setContenido(int param1) { contenido = param1; }

        public int getContenido() { return contenido; }

        public bool hasVasos(int cantidadVasos)
        {
            if (this.cantidadVasos>= cantidadVasos) return true;
            return false;
        }

        public void giveVasos(int cantidadVasos)
        {
            this.cantidadVasos -= cantidadVasos;
        }
    }
}
